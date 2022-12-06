using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP
{
    public partial class ActivityTwoForm : Form
    {
        private activityOneForm activityOneForm;

        public ActivityTwoForm()
        {
            InitializeComponent();
        }

        public ActivityTwoForm(activityOneForm activityOneForm)
        {
            InitializeComponent();
            this.activityOneForm = activityOneForm;
        }

        private void openForegroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Loads an image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Sets properties of dialog
                openFileDialog.Title = "Open Image";
                openFileDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foregroundPictureBox.Image = new Bitmap(openFileDialog.FileName);
                    modeToolStripButton.Enabled = true;
                }
            }
        }

        private void openBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Loads an image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Sets properties of dialog
                openFileDialog.Title = "Open Image";
                openFileDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    backgroundPictureBox.Image = new Bitmap(openFileDialog.FileName);
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

        private void switchButton_Click(object sender, EventArgs e)
        {
            Close();
            
            activityOneForm.Show();
            activityOneForm.Location = Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                                            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2); ;
        }

        private void ActivityTwoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            activityOneForm.Show();
        }
    }
}
