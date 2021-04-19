using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Igtampe.TileMosaicMaker {
    
    /// <summary>Main form that handles everything</summary>
    public partial class MainForm:Form {

        //-[Fields]------------------------------------------------------------------------------------------------

        /// <summary>All images to tile</summary>
        private readonly Dictionary<string,Bitmap> Tileset = new Dictionary<string,Bitmap>();
        
        /// <summary>Image that has all the tiles tiled, and is to be exported</summary>
        public Bitmap ExportImage;

        /// <summary>Width of the image in tiles</summary>
        private int WidthTiles=0;

        /// <summary>Height of the image in tiles</summary>
        private int HeightTiles=0;

        /// <summary>Width of each tile</summary>
        private int TileWidth = 0;

        /// <summary>Height of each Tile</summary>
        private int TileHeight = 0;

        /// <summary>Randomizer to randomize tiles.</summary>
        private readonly Random IntRandomizer = new Random();

        /// <summary>GRD to draw the image over an image</summary>
        private Graphics grD;

        //-[Constructors]------------------------------------------------------------------------------------------------

        /// <summary>Creates a mainform</summary>
        public MainForm() {InitializeComponent();}

        //-[UI Interaction]------------------------------------------------------------------------------------------------

        /// <summary>Adds a tile to the tile list</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTileButton_Click(object sender,EventArgs e) {
            if(TileOFD.ShowDialog() == DialogResult.OK) {
                foreach(string F in TileOFD.FileNames) {AddImageToTileset(F);}
                RelistListview(); 
            }
        }

        /// <summary>Exports the ExportImage</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportButton_Click(object sender,EventArgs e) {
            if(ExportSFD.ShowDialog() == DialogResult.OK) { ExportImage.Save(ExportSFD.FileName,System.Drawing.Imaging.ImageFormat.Png); }
        }

        /// <summary>Regenerates the tileset</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegenerateButton_Click(object sender,EventArgs e) { RedrawImage(); }

        /// <summary>Delete Item</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem_Click(object sender,EventArgs e) {
            if(TilesListView.SelectedItems.Count != 1) { return; } //If there isn't anything selected, go back
            Tileset.Remove(TilesListView.SelectedItems[0].Text); //Remove
            if(Tileset.Count == 0) {TileWidth = 0; TileHeight = 0;} //if there's nothing reset the tile dimension
            RelistListview(); //Relist listview
        }

        /// <summary>Sets the width in tiles</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthNumUpDown_ValueChanged(object sender,EventArgs e) {
            WidthTiles = Convert.ToInt32(WidthNumUpDown.Value);
            RedrawImage();
        }

        /// <summary>Sets the height of the image in tiles</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightNumUpDown_ValueChanged(object sender,EventArgs e) {
            HeightTiles = Convert.ToInt32(HeightNumUpDown.Value);
            RedrawImage();
        }

        /// <summary>Handles draging something into the tile list view</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TilesListView_DragEnter(object sender,DragEventArgs e) {
            if(e.Data.GetDataPresent(DataFormats.FileDrop)) { e.Effect = DragDropEffects.Copy; }

        }

        /// <summary>Actually does the thing</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TilesListView_DragDrop(object sender,DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(string f in files) {AddImageToTileset(f);}
            RelistListview();
        }

        //-[Methods]------------------------------------------------------------------------------------------------

        /// <summary>Relists all items on the listview</summary>
        private void RelistListview() {
            TilesListView.Items.Clear();
            foreach(string F in Tileset.Keys) {TilesListView.Items.Add(new ListViewItem(F));}
        }

        /// <summary>Adds an image to the tileset</summary>
        /// <param name="Filename"></param>
        private void AddImageToTileset(string Filename) {
            Bitmap temp;
            try {temp = new Bitmap(Filename);} catch(Exception) {return;}
            if(TileWidth != 0 && TileHeight != 0) {
                if(temp.Width != TileWidth || temp.Height != TileHeight) {
                    MessageBox.Show("New tile does not match width and height of previous tiles","no",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }

            if(TileWidth == 0 && TileHeight == 0) {
                TileWidth = temp.Width;
                TileHeight = temp.Height;
            }

            if(Tileset.ContainsKey(Filename)) {
                MessageBox.Show("Tile is already in the system.","no",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Tileset.Add(Filename,temp);
        }

        /// <summary>Starts the backgroundworker</summary>
        private void RedrawImage() {
            OptionsGroupBox.Enabled = false;
            TilesGroupBox.Enabled = false;
            ProgBar.Value = 0;
            Worker.RunWorkerAsync();
        }

        /// <summary>Pastes image P at X,Y coord into ExportImage</summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="P"></param>
        private void PasteImage(int X,int Y,Bitmap P) {grD.DrawImage(P,new Rectangle(X,Y,TileWidth,TileHeight),new Rectangle(0,0,TileWidth,TileHeight),GraphicsUnit.Pixel);}

        //-[Background Worker]------------------------------------------------------------------------------------------------

        /// <summary>Recreates the tile mosaic</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Worker_DoWork(object sender,System.ComponentModel.DoWorkEventArgs e) {

            ExportImage = null;

            //if there are not tiles then show it and then leave
            if(Tileset.Count == 0 || (WidthTiles == 0 || HeightTiles == 0)) {
                PreviewPicturebox.Image = Properties.Resources.NoTiles;
                return;
            }

            //now create an image with the right size. Try to do so and if something goes wrong then just return.
            try {ExportImage = new Bitmap(WidthTiles * TileWidth,HeightTiles * TileHeight);} catch(ArgumentException) {return;}
            

            grD=Graphics.FromImage(ExportImage);

            //get the images
            List<Bitmap> Images = new List<Bitmap>(Tileset.Values);

            //Let's randomize it
            List<Bitmap> ImagesRandom = new List<Bitmap>(Images.Count);

            //Randomizer
            while(Images.Count != 0) {
                //move a random index to the new list
                int index = IntRandomizer.Next(0,Images.Count - 1);
                ImagesRandom.Add(Images[index]);
                Images.RemoveAt(index);
            }

            int ImageIndex = 0;

            //Now that we've got a new list 
            for(int TileY = 0; TileY < HeightTiles; TileY++) {
                for(int TileX = 0; TileX < WidthTiles; TileX++) {

                    //Put in a tile!
                    PasteImage(TileX * TileWidth,TileY * TileHeight,ImagesRandom[ImageIndex]);
                    ImageIndex++;
                    double progress = ((0.0+TileX+(TileY*WidthTiles))/(0.0+WidthTiles*HeightTiles))*100;
                    Worker.ReportProgress(Convert.ToInt32(progress));
                    //Console.WriteLine(progress);

                    if(ImageIndex >= ImagesRandom.Count) { ImageIndex = 0; }

                }
            }
        }

        /// <summary>Reports progress</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Worker_Report(object sender, System.ComponentModel.ProgressChangedEventArgs e) {
            ProgBar.Value = e.ProgressPercentage;
            //PreviewPicturebox.Image = ExportImage;
        }

        /// <summary>Executes when the worker's done</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Worker_Complete(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            OptionsGroupBox.Enabled = true;
            TilesGroupBox.Enabled = true;
            ProgBar.Value = 0;
            if(ExportImage != null) { PreviewPicturebox.Image = ExportImage; }
        }

    }
}
