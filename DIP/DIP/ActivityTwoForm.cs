using AForge.Video;
using AForge.Video.DirectShow;
using DIP.ImageProcessors;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

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
                    byte threshold = byte.Parse(firstTextBox.Text);
                    threshold = Math.Min(byte.MaxValue, threshold);
                    processedPictureBox.Image = Subtraction.Process((Bitmap)foregroundPictureBox.Image, 
                                                                    (Bitmap)backgroundPictureBox.Image,
                                                                    (byte) threshold);
                }) },
                {"livesubtraction", (() =>
                {
                    byte threshold = byte.Parse(firstTextBox.Text);
                    threshold = Math.Min(byte.MaxValue, threshold);
                    processedPictureBox.Image = LiveSubtraction.Process((Bitmap)foregroundPictureBox.Image,
                                                                        (Bitmap)backgroundPictureBox.Image,
                                                                        (byte) threshold);
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

        private void openCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cameraComboBox.Items.Add(Device.Name);
            cameraComboBox.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();

            foregroundImageLoaded = true;

            if (foregroundImageLoaded && backgroundImageLoaded)
            {
                modeToolStripButton.Enabled = true;
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

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processButton.Enabled = true;
            firstTextBox.Enabled = true;
            modeLabel.Text = "Mode : Subtraction";
            mode = "subtraction";
        }

        private void liveSubtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processButton.Enabled = true;
            firstTextBox.Enabled = true;
            cameraComboBox.Enabled = true;
            modeLabel.Text = "Mode : Live Subtraction";
            mode = "livesubtraction";
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

                if (firstTextBox.Text.Length <= 0) return;

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

        private void cameraComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraComboBox.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            foregroundPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ActivityTwoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            activityOneForm.Show();

            if (videoCaptureDevice == null) return;

            // Stops camera
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }
    }
}
