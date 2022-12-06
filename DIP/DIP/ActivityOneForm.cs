using DIP.ImageProcessors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP
{
    public partial class activityOneForm : Form
    {
        string mode;
        private Dictionary<string, Action> processorFactory;
        public activityOneForm()
        {
            InitializeComponent();

            // Initialize Processor Factory
            processorFactory = new Dictionary<string, Action>()
            {
                {"copy", (() =>
                {
                    processedPictureBox.Image = Copy.Process((Bitmap)originalPictureBox.Image);
                }) },
                {"greyscale", (() =>
                {
                    processedPictureBox.Image = Greyscale.Process((Bitmap)originalPictureBox.Image);
                }) },
                {"colorinversion", (() =>
                {
                    processedPictureBox.Image = ColorInversion.Process((Bitmap)originalPictureBox.Image);
                }) },
                {"histogram", (() =>
                {
                    processedPictureBox.Image = Histogram.Process((Bitmap)originalPictureBox.Image);
                }) },
                {"sepia", (() =>
                {
                    processedPictureBox.Image = Sepia.Process((Bitmap)originalPictureBox.Image);
                }) },
            };
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

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processButton.Enabled = true;
            modeLabel.Text = "Mode : Sepia";
            mode = "sepia";
        }

        private async void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Turns on progress bar
                progressBar.Visible = true;

                // Disables process button
                processButton.Enabled = false;

                // Runs the action with the corresponding mode
                await Task.Run(processorFactory[mode]);
            }
            finally
            {
                // Turns off progress bar
                progressBar.Visible = false;

                // Enables process button
                processButton.Enabled = true;
            }
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            Hide();
            ActivityTwoForm activityTwoForm = new ActivityTwoForm(this);
            activityTwoForm.ShowDialog();
        }
    }
}
