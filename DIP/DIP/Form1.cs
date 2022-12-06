using DIP.ImageProcessors;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP
{
    public partial class formDefault : Form
    {
        string mode;

        public formDefault()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Loads an image
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Sets properties of dialog
                openFileDialog.Title = "Open Image";
                openFileDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalPictureBox.Image = new Bitmap(openFileDialog.FileName);
                    modeToolStripButton.Enabled = true;
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Saves an image
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Sets properties of dialog
                saveFileDialog.Title = "Save Image";
                saveFileDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    processedPictureBox.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processButton.Enabled = true;
            modeLabel.Text = "Mode : Copy";
            mode = "copy";
        }
        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processButton.Enabled = true;
            modeLabel.Text = "Mode : Greyscale";
            mode = "greyscale";
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processButton.Enabled = true;
            modeLabel.Text = "Mode : Color Inversion";
            mode = "colorinversion";
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processButton.Enabled = true;
            modeLabel.Text = "Mode : Histogram";
            mode = "histogram";
        }

        private async void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Turns on progress bar
                progressBar.Visible = true;

                // Disables process button
                processButton.Enabled = false;

                switch (mode)
                {
                    // Runs the copy function
                    case "copy":
                        await Task.Run(() =>
                        {
                            processedPictureBox.Image = Copy.Process((Bitmap)originalPictureBox.Image);
                        });
                        break;

                    // Runs the greyscale function
                    case "greyscale":
                        await Task.Run(() =>
                        {
                            processedPictureBox.Image = Greyscale.Process((Bitmap)originalPictureBox.Image);
                        });
                        break;

                    // Runs the inversion function
                    case "colorinversion":
                        await Task.Run(() =>
                        {
                            processedPictureBox.Image = ColorInversion.Process((Bitmap)originalPictureBox.Image);
                        });
                        break;

                    // Runs the histogram function
                    case "histogram":
                        await Task.Run(() =>
                        {
                            processedPictureBox.Image = Histogram.Process((Bitmap)originalPictureBox.Image);
                        });
                        break;
                }
            }
            finally
            {
                // Turns off progress bar
                progressBar.Visible = false;

                // Enables process button
                processButton.Enabled = true;
            }
        }
    }
}
