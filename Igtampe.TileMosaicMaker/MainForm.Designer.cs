
namespace Igtampe.TileMosaicMaker {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.PreviewPicturebox = new System.Windows.Forms.PictureBox();
            this.TilesGroupBox = new System.Windows.Forms.GroupBox();
            this.TilesTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddTileButton = new System.Windows.Forms.Button();
            this.TilesListView = new System.Windows.Forms.ListView();
            this.ColumnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TileContentMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.HeightNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExportButton = new System.Windows.Forms.Button();
            this.RegenerateButton = new System.Windows.Forms.Button();
            this.ProgBar = new System.Windows.Forms.ProgressBar();
            this.ExportSFD = new System.Windows.Forms.SaveFileDialog();
            this.TileOFD = new System.Windows.Forms.OpenFileDialog();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.MainTableLayout.SuspendLayout();
            this.PreviewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicturebox)).BeginInit();
            this.TilesGroupBox.SuspendLayout();
            this.TilesTableLayout.SuspendLayout();
            this.TileContentMenuStrip.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.MainTableLayout.Controls.Add(this.PreviewGroupBox, 0, 0);
            this.MainTableLayout.Controls.Add(this.TilesGroupBox, 1, 0);
            this.MainTableLayout.Controls.Add(this.OptionsGroupBox, 1, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainTableLayout.Size = new System.Drawing.Size(1019, 569);
            this.MainTableLayout.TabIndex = 0;
            // 
            // PreviewGroupBox
            // 
            this.PreviewGroupBox.Controls.Add(this.PreviewPicturebox);
            this.PreviewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewGroupBox.Location = new System.Drawing.Point(3, 3);
            this.PreviewGroupBox.Name = "PreviewGroupBox";
            this.MainTableLayout.SetRowSpan(this.PreviewGroupBox, 2);
            this.PreviewGroupBox.Size = new System.Drawing.Size(733, 563);
            this.PreviewGroupBox.TabIndex = 0;
            this.PreviewGroupBox.TabStop = false;
            this.PreviewGroupBox.Text = "Preview";
            // 
            // PreviewPicturebox
            // 
            this.PreviewPicturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPicturebox.Image = global::Igtampe.TileMosaicMaker.Properties.Resources.NoTiles;
            this.PreviewPicturebox.Location = new System.Drawing.Point(3, 16);
            this.PreviewPicturebox.Name = "PreviewPicturebox";
            this.PreviewPicturebox.Size = new System.Drawing.Size(727, 544);
            this.PreviewPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewPicturebox.TabIndex = 0;
            this.PreviewPicturebox.TabStop = false;
            // 
            // TilesGroupBox
            // 
            this.TilesGroupBox.Controls.Add(this.TilesTableLayout);
            this.TilesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TilesGroupBox.Location = new System.Drawing.Point(742, 3);
            this.TilesGroupBox.Name = "TilesGroupBox";
            this.TilesGroupBox.Size = new System.Drawing.Size(274, 413);
            this.TilesGroupBox.TabIndex = 1;
            this.TilesGroupBox.TabStop = false;
            this.TilesGroupBox.Text = "Tiles";
            // 
            // TilesTableLayout
            // 
            this.TilesTableLayout.ColumnCount = 2;
            this.TilesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TilesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TilesTableLayout.Controls.Add(this.AddTileButton, 1, 1);
            this.TilesTableLayout.Controls.Add(this.TilesListView, 0, 0);
            this.TilesTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TilesTableLayout.Location = new System.Drawing.Point(3, 16);
            this.TilesTableLayout.Name = "TilesTableLayout";
            this.TilesTableLayout.RowCount = 2;
            this.TilesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TilesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TilesTableLayout.Size = new System.Drawing.Size(268, 394);
            this.TilesTableLayout.TabIndex = 2;
            // 
            // AddTileButton
            // 
            this.AddTileButton.Location = new System.Drawing.Point(191, 367);
            this.AddTileButton.Name = "AddTileButton";
            this.AddTileButton.Size = new System.Drawing.Size(74, 23);
            this.AddTileButton.TabIndex = 0;
            this.AddTileButton.Text = "Add";
            this.AddTileButton.UseVisualStyleBackColor = true;
            this.AddTileButton.Click += new System.EventHandler(this.AddTileButton_Click);
            // 
            // TilesListView
            // 
            this.TilesListView.AllowDrop = true;
            this.TilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader0});
            this.TilesTableLayout.SetColumnSpan(this.TilesListView, 2);
            this.TilesListView.ContextMenuStrip = this.TileContentMenuStrip;
            this.TilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TilesListView.HideSelection = false;
            this.TilesListView.Location = new System.Drawing.Point(3, 3);
            this.TilesListView.Name = "TilesListView";
            this.TilesListView.Size = new System.Drawing.Size(262, 358);
            this.TilesListView.TabIndex = 1;
            this.TilesListView.UseCompatibleStateImageBehavior = false;
            this.TilesListView.View = System.Windows.Forms.View.Details;
            this.TilesListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.TilesListView_DragDrop);
            this.TilesListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.TilesListView_DragEnter);
            // 
            // ColumnHeader0
            // 
            this.ColumnHeader0.Text = "Image";
            this.ColumnHeader0.Width = 250;
            // 
            // TileContentMenuStrip
            // 
            this.TileContentMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.TileContentMenuStrip.Name = "TileContentMenuStrip";
            this.TileContentMenuStrip.Size = new System.Drawing.Size(132, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsGroupBox.Location = new System.Drawing.Point(742, 422);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(274, 144);
            this.OptionsGroupBox.TabIndex = 2;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.HeightNumUpDown, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.WidthNumUpDown, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ExportButton, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.RegenerateButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ProgBar, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(268, 121);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // HeightNumUpDown
            // 
            this.HeightNumUpDown.Location = new System.Drawing.Point(137, 33);
            this.HeightNumUpDown.Name = "HeightNumUpDown";
            this.HeightNumUpDown.Size = new System.Drawing.Size(120, 20);
            this.HeightNumUpDown.TabIndex = 4;
            this.HeightNumUpDown.ValueChanged += new System.EventHandler(this.HeightNumUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Width (Tiles)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image Height (Tiles)";
            // 
            // WidthNumUpDown
            // 
            this.WidthNumUpDown.Location = new System.Drawing.Point(137, 3);
            this.WidthNumUpDown.Name = "WidthNumUpDown";
            this.WidthNumUpDown.Size = new System.Drawing.Size(120, 20);
            this.WidthNumUpDown.TabIndex = 3;
            this.WidthNumUpDown.ValueChanged += new System.EventHandler(this.WidthNumUpDown_ValueChanged);
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(137, 93);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(128, 23);
            this.ExportButton.TabIndex = 8;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // RegenerateButton
            // 
            this.RegenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegenerateButton.Location = new System.Drawing.Point(137, 63);
            this.RegenerateButton.Name = "RegenerateButton";
            this.RegenerateButton.Size = new System.Drawing.Size(128, 23);
            this.RegenerateButton.TabIndex = 9;
            this.RegenerateButton.Text = "Regenerate";
            this.RegenerateButton.UseVisualStyleBackColor = true;
            this.RegenerateButton.Click += new System.EventHandler(this.RegenerateButton_Click);
            // 
            // ProgBar
            // 
            this.ProgBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgBar.Location = new System.Drawing.Point(3, 93);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(128, 25);
            this.ProgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgBar.TabIndex = 10;
            // 
            // ExportSFD
            // 
            this.ExportSFD.DefaultExt = "png";
            this.ExportSFD.FileName = "TileMosaic.png";
            this.ExportSFD.Title = "Export";
            // 
            // TileOFD
            // 
            this.TileOFD.DefaultExt = "png";
            this.TileOFD.FileName = "Tile.png";
            this.TileOFD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            this.TileOFD.Multiselect = true;
            this.TileOFD.Title = "Add a Tile";
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_Report);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_Complete);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 569);
            this.Controls.Add(this.MainTableLayout);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tile Mosaic Maker (Version 1.0)";
            this.MainTableLayout.ResumeLayout(false);
            this.PreviewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicturebox)).EndInit();
            this.TilesGroupBox.ResumeLayout(false);
            this.TilesTableLayout.ResumeLayout(false);
            this.TileContentMenuStrip.ResumeLayout(false);
            this.OptionsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.GroupBox PreviewGroupBox;
        private System.Windows.Forms.PictureBox PreviewPicturebox;
        private System.Windows.Forms.GroupBox TilesGroupBox;
        private System.Windows.Forms.TableLayoutPanel TilesTableLayout;
        private System.Windows.Forms.Button AddTileButton;
        private System.Windows.Forms.ListView TilesListView;
        private System.Windows.Forms.ContextMenuStrip TileContentMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.ColumnHeader ColumnHeader0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown HeightNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown WidthNumUpDown;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.SaveFileDialog ExportSFD;
        private System.Windows.Forms.OpenFileDialog TileOFD;
        private System.Windows.Forms.Button RegenerateButton;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.ProgressBar ProgBar;
    }
}

