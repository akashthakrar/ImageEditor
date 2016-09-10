namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsLinearCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueModifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturationAdjusingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessAdjustingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastAdjustingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSLFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCbCrLinearCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCbCrFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdBinarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floydSteinbergDitheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderedDitheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
            this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem2.Text = "E&xit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.rotateChannelToolStripMenuItem,
            this.colorFilteringToolStripMenuItem,
            this.levelsLinearCorrectionToolStripMenuItem,
            this.hueModifierToolStripMenuItem,
            this.saturationAdjusingToolStripMenuItem,
            this.brightnessAdjustingToolStripMenuItem,
            this.contrastAdjustingToolStripMenuItem,
            this.hSLFilteringToolStripMenuItem,
            this.yCbCrLinearCorrectionToolStripMenuItem,
            this.yCbCrFilteringToolStripMenuItem,
            this.thresholdBinarizationToolStripMenuItem,
            this.floydSteinbergDitheringToolStripMenuItem,
            this.orderedDitheringToolStripMenuItem,
            this.convolutionToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // imageBox
            // 
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(0, 24);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(570, 373);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Title = "Open Image";
            // 
            // saveFile
            // 
            this.saveFile.CheckPathExists = false;
            this.saveFile.DefaultExt = "*.jpg";
            this.saveFile.Filter = "JPEG Image | *.jpg";
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // rotateChannelToolStripMenuItem
            // 
            this.rotateChannelToolStripMenuItem.Name = "rotateChannelToolStripMenuItem";
            this.rotateChannelToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.rotateChannelToolStripMenuItem.Text = "Rotate Channel";
            this.rotateChannelToolStripMenuItem.Click += new System.EventHandler(this.rotateChannelToolStripMenuItem_Click);
            // 
            // colorFilteringToolStripMenuItem
            // 
            this.colorFilteringToolStripMenuItem.Name = "colorFilteringToolStripMenuItem";
            this.colorFilteringToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.colorFilteringToolStripMenuItem.Text = "Color filtering";
            this.colorFilteringToolStripMenuItem.Click += new System.EventHandler(this.colorFilteringToolStripMenuItem_Click);
            // 
            // levelsLinearCorrectionToolStripMenuItem
            // 
            this.levelsLinearCorrectionToolStripMenuItem.Name = "levelsLinearCorrectionToolStripMenuItem";
            this.levelsLinearCorrectionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.levelsLinearCorrectionToolStripMenuItem.Text = "Levels linear correction";
            this.levelsLinearCorrectionToolStripMenuItem.Click += new System.EventHandler(this.levelsLinearCorrectionToolStripMenuItem_Click);
            // 
            // hueModifierToolStripMenuItem
            // 
            this.hueModifierToolStripMenuItem.Name = "hueModifierToolStripMenuItem";
            this.hueModifierToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.hueModifierToolStripMenuItem.Text = "Hue modifier";
            this.hueModifierToolStripMenuItem.Click += new System.EventHandler(this.hueModifierToolStripMenuItem_Click);
            // 
            // saturationAdjusingToolStripMenuItem
            // 
            this.saturationAdjusingToolStripMenuItem.Name = "saturationAdjusingToolStripMenuItem";
            this.saturationAdjusingToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saturationAdjusingToolStripMenuItem.Text = "Saturation adjusting";
            this.saturationAdjusingToolStripMenuItem.Click += new System.EventHandler(this.saturationAdjusingToolStripMenuItem_Click);
            // 
            // brightnessAdjustingToolStripMenuItem
            // 
            this.brightnessAdjustingToolStripMenuItem.Name = "brightnessAdjustingToolStripMenuItem";
            this.brightnessAdjustingToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.brightnessAdjustingToolStripMenuItem.Text = "Brightness adjusting";
            this.brightnessAdjustingToolStripMenuItem.Click += new System.EventHandler(this.brightnessAdjustingToolStripMenuItem_Click);
            // 
            // contrastAdjustingToolStripMenuItem
            // 
            this.contrastAdjustingToolStripMenuItem.Name = "contrastAdjustingToolStripMenuItem";
            this.contrastAdjustingToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.contrastAdjustingToolStripMenuItem.Text = "Contrast adjusting";
            this.contrastAdjustingToolStripMenuItem.Click += new System.EventHandler(this.contrastAdjustingToolStripMenuItem_Click);
            // 
            // hSLFilteringToolStripMenuItem
            // 
            this.hSLFilteringToolStripMenuItem.Name = "hSLFilteringToolStripMenuItem";
            this.hSLFilteringToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.hSLFilteringToolStripMenuItem.Text = "HSL filtering";
            this.hSLFilteringToolStripMenuItem.Click += new System.EventHandler(this.hSLFilteringToolStripMenuItem_Click);
            // 
            // yCbCrLinearCorrectionToolStripMenuItem
            // 
            this.yCbCrLinearCorrectionToolStripMenuItem.Name = "yCbCrLinearCorrectionToolStripMenuItem";
            this.yCbCrLinearCorrectionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.yCbCrLinearCorrectionToolStripMenuItem.Text = "YCbCr linear correction";
            this.yCbCrLinearCorrectionToolStripMenuItem.Click += new System.EventHandler(this.yCbCrLinearCorrectionToolStripMenuItem_Click);
            // 
            // yCbCrFilteringToolStripMenuItem
            // 
            this.yCbCrFilteringToolStripMenuItem.Name = "yCbCrFilteringToolStripMenuItem";
            this.yCbCrFilteringToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.yCbCrFilteringToolStripMenuItem.Text = "YCbCr filtering";
            this.yCbCrFilteringToolStripMenuItem.Click += new System.EventHandler(this.yCbCrFilteringToolStripMenuItem_Click);
            // 
            // thresholdBinarizationToolStripMenuItem
            // 
            this.thresholdBinarizationToolStripMenuItem.Name = "thresholdBinarizationToolStripMenuItem";
            this.thresholdBinarizationToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.thresholdBinarizationToolStripMenuItem.Text = "Threshold binarization";
            this.thresholdBinarizationToolStripMenuItem.Click += new System.EventHandler(this.thresholdBinarizationToolStripMenuItem_Click);
            // 
            // floydSteinbergDitheringToolStripMenuItem
            // 
            this.floydSteinbergDitheringToolStripMenuItem.Name = "floydSteinbergDitheringToolStripMenuItem";
            this.floydSteinbergDitheringToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.floydSteinbergDitheringToolStripMenuItem.Text = "Floyd-Steinberg dithering";
            this.floydSteinbergDitheringToolStripMenuItem.Click += new System.EventHandler(this.floydSteinbergDitheringToolStripMenuItem_Click);
            // 
            // orderedDitheringToolStripMenuItem
            // 
            this.orderedDitheringToolStripMenuItem.Name = "orderedDitheringToolStripMenuItem";
            this.orderedDitheringToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.orderedDitheringToolStripMenuItem.Text = "Ordered dithering";
            this.orderedDitheringToolStripMenuItem.Click += new System.EventHandler(this.orderedDitheringToolStripMenuItem_Click);
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.convolutionToolStripMenuItem.Text = "Convolution";
            this.convolutionToolStripMenuItem.Click += new System.EventHandler(this.convolutionToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem1.Text = "Difference Edge detector";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem2.Text = "Homogenity edge detector";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem3.Text = "Sobel edge detector";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem4.Text = "Jitter";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem5.Text = "Oil Painting";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem6.Text = "Texture";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid.Location = new System.Drawing.Point(366, 24);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(204, 373);
            this.propertyGrid.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 397);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelsLinearCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hueModifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saturationAdjusingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessAdjustingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastAdjustingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSLFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yCbCrLinearCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yCbCrFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdBinarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floydSteinbergDitheringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderedDitheringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.PropertyGrid propertyGrid;
    }
}

