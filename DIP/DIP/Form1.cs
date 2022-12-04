using DIP.ImageProcessors;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DIP
{
    public partial class formDefault : Form
    {
        public formDefault()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Loads and open an image
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open Image";
                openFileDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalPictureBox.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processButton.Enabled = true;
            modeLabel.Text = "Mode : Copy";
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            new Thread(()=>
            {
                processedPictureBox.Image = Copy.Process((Bitmap)originalPictureBox.Image);
            }).Start();
        }

    }
}
