using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.ColorReduction;
using AForge.Imaging.Formats;

namespace ImageEditor
{
    public partial class Form1 : Form
    {

        private System.Drawing.Bitmap sourceImage;
        private System.Drawing.Bitmap filteredImage;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    sourceImage = (Bitmap)Bitmap.FromFile(openFile.FileName);
                    imageBox.Image = null;
                    toolsToolStripMenuItem.Enabled = true;
                    ImageInfo imageInfo = null;

                    imageBox.Image = ImageDecoder.DecodeFromFile(openFile.FileName, out imageInfo);

                    propertyGrid.SelectedObject = imageInfo;
                    propertyGrid.ExpandAllGridItems();

                }
            }
            catch
            {
                MessageBox.Show("Failed loading the image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCurrentImage();
            imageBox.Image = sourceImage;
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(Grayscale.CommonAlgorithms.BT709);
        }

        private void ClearCurrentImage()
        {
            imageBox.Image = null;
            if ((noneToolStripMenuItem.Checked == false) && (filteredImage != null))
            {
                filteredImage.Dispose();
                filteredImage = null;
            }
        }

        private void ApplyFilter(IFilter filter)
        {
            imageBox.Image = null;
            Bitmap filteredImage = filter.Apply(sourceImage);
            imageBox.Image = filteredImage;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                imageBox.Image.Save(saveFile.FileName);
            }
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sepia());
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Invert());
        }

        private void rotateChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new RotateChannels());
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ColorFiltering(new IntRange(25, 230), new IntRange(25, 230), new IntRange(25, 230)));
        }

        private void levelsLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelsLinear filter = new LevelsLinear();

            filter.InRed = new IntRange(30, 230);
            filter.InGreen = new IntRange(50, 240);
            filter.InBlue = new IntRange(10, 210);

            ApplyFilter(filter);
        }

        private void hueModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new HueModifier(50));
        }

        private void saturationAdjusingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new SaturationCorrection(0.15f));
        }

        private void brightnessAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new BrightnessCorrection());
        }

        private void contrastAdjustingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ContrastCorrection());
        }

        private void hSLFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new HSLFiltering(new IntRange(330, 30), new Range(0, 1), new Range(0, 1)));
        }

        private void yCbCrLinearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YCbCrLinear filter = new YCbCrLinear();

            filter.InCb = new Range(-0.3f, 0.3f);

            ApplyFilter(filter);
        }

        private void yCbCrFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new YCbCrFiltering(new Range(0.2f, 0.9f), new Range(-0.3f, 0.3f), new Range(-0.3f, 0.3f)));
        }

        private void thresholdBinarizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            ApplyFilter(new Threshold());
            sourceImage.Dispose();
            sourceImage = originalImage;
        }

        private void floydSteinbergDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            ApplyFilter(new FloydSteinbergDithering());
            sourceImage.Dispose();
            sourceImage = originalImage;
        }

        private void orderedDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            ApplyFilter(new OrderedDithering());
            sourceImage.Dispose();
            sourceImage = originalImage;
        }

        private void convolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Convolution(new int[,] {
								{ 1, 2, 3, 2, 1 },
								{ 2, 4, 5, 4, 2 },
								{ 3, 5, 6, 5, 3 },
								{ 2, 4, 5, 4, 2 },
								{ 1, 2, 3, 2, 1 } }));
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sharpen());
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new GaussianBlur(2.0, 7));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            ApplyFilter(new DifferenceEdgeDetector());
            sourceImage.Dispose();
            sourceImage = originalImage;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            ApplyFilter(new HomogenityEdgeDetector());
            sourceImage.Dispose();
            sourceImage = originalImage;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = sourceImage;
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            ApplyFilter(new SobelEdgeDetector());
            sourceImage.Dispose();
            sourceImage = originalImage;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Jitter());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ApplyFilter(new OilPainting());
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Texturer(new TextileTexture(), 1.0, 0.8));
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about a1 = new about();
            a1.Show();
        }

    }
}
