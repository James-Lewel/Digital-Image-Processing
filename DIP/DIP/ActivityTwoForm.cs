﻿using DIP.ImageProcessors;
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
        string mode;
        private Dictionary<string, Action> processorFactory;

        private activityOneForm activityOneForm;
        private bool foregroundImageLoaded = false;
        private bool backgroundImageLoaded = false;

        public ActivityTwoForm()
        {
            InitializeComponent();
        }

        public ActivityTwoForm(activityOneForm activityOneForm)
        {
            InitializeComponent();
            this.activityOneForm = activityOneForm;


            // Initialize Processor Factory
            processorFactory = new Dictionary<string, Action>()
            {
                {"subtraction", (() =>
                {
                    processedPictureBox.Image = Subtraction.Process((Bitmap)foregroundPictureBox.Image, (Bitmap)backgroundPictureBox.Image);
                }) }
            };
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
                    foregroundImageLoaded = true;
                    
                    if(foregroundImageLoaded && backgroundImageLoaded)
                    {
                        modeToolStripButton.Enabled = true;
                    }
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
                    backgroundImageLoaded = true;

                    if (foregroundImageLoaded && backgroundImageLoaded)
                    {
                        modeToolStripButton.Enabled = true;
                    }
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

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processButton.Enabled = true;
            modeLabel.Text = "Mode : Subtraction";
            mode = "subtraction";
        }

        private async void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Turns on progress bar
                progressBar.Visible = true;

                // Disables process button
                processButton.Enabled = false;
                saveFileToolStripMenuItem.Enabled = true;

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
    }
}
