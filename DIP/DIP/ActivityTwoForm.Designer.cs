namespace DIP
{
    partial class ActivityTwoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityTwoForm));
            this.processButton = new System.Windows.Forms.Button();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStripDefault = new System.Windows.Forms.StatusStrip();
            this.modeLabel = new System.Windows.Forms.Label();
            this.modeToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.subtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveSubtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openForegroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDefault = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.switchButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.processedPictureBox = new System.Windows.Forms.PictureBox();
            this.foregroundPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStripDefault.SuspendLayout();
            this.toolStripDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // processButton
            // 
            this.processButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processButton.Enabled = false;
            this.processButton.Location = new System.Drawing.Point(203, 31);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(96, 23);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // firstTextBox
            // 
            this.firstTextBox.Enabled = false;
            this.firstTextBox.Location = new System.Drawing.Point(87, 7);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select Camera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Value";
            // 
            // progressBar
            // 
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Step = 25;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.Visible = false;
            // 
            // statusStripDefault
            // 
            this.statusStripDefault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStripDefault.Location = new System.Drawing.Point(0, 539);
            this.statusStripDefault.Name = "statusStripDefault";
            this.statusStripDefault.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStripDefault.Size = new System.Drawing.Size(784, 22);
            this.statusStripDefault.TabIndex = 10;
            this.statusStripDefault.Text = "statusStrip1";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(203, 10);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(69, 13);
            this.modeLabel.TabIndex = 0;
            this.modeLabel.Text = "Mode : None";
            // 
            // modeToolStripButton
            // 
            this.modeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modeToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subtractionToolStripMenuItem,
            this.liveSubtractionToolStripMenuItem});
            this.modeToolStripButton.Enabled = false;
            this.modeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("modeToolStripButton.Image")));
            this.modeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modeToolStripButton.Name = "modeToolStripButton";
            this.modeToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.modeToolStripButton.Text = "Mode";
            // 
            // subtractionToolStripMenuItem
            // 
            this.subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            this.subtractionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.subtractionToolStripMenuItem.Text = "Subtraction";
            this.subtractionToolStripMenuItem.Click += new System.EventHandler(this.subtractionToolStripMenuItem_Click);
            // 
            // liveSubtractionToolStripMenuItem
            // 
            this.liveSubtractionToolStripMenuItem.Name = "liveSubtractionToolStripMenuItem";
            this.liveSubtractionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.liveSubtractionToolStripMenuItem.Text = "Live Subtraction";
            this.liveSubtractionToolStripMenuItem.Click += new System.EventHandler(this.liveSubtractionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Enabled = false;
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveFileToolStripMenuItem.Text = "Save";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openForegroundToolStripMenuItem,
            this.openBackgroundToolStripMenuItem,
            this.openCameraToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openFileToolStripMenuItem.Text = "Open";
            // 
            // openForegroundToolStripMenuItem
            // 
            this.openForegroundToolStripMenuItem.Name = "openForegroundToolStripMenuItem";
            this.openForegroundToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openForegroundToolStripMenuItem.Text = "Open Foreground";
            this.openForegroundToolStripMenuItem.Click += new System.EventHandler(this.openForegroundToolStripMenuItem_Click);
            // 
            // openBackgroundToolStripMenuItem
            // 
            this.openBackgroundToolStripMenuItem.Name = "openBackgroundToolStripMenuItem";
            this.openBackgroundToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openBackgroundToolStripMenuItem.Text = "Open Background";
            this.openBackgroundToolStripMenuItem.Click += new System.EventHandler(this.openBackgroundToolStripMenuItem_Click);
            // 
            // openCameraToolStripMenuItem
            // 
            this.openCameraToolStripMenuItem.Name = "openCameraToolStripMenuItem";
            this.openCameraToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openCameraToolStripMenuItem.Text = "Open Camera";
            this.openCameraToolStripMenuItem.Click += new System.EventHandler(this.openCameraToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripSplitButton1.Text = "File";
            // 
            // toolStripDefault
            // 
            this.toolStripDefault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.modeToolStripButton,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.switchButton});
            this.toolStripDefault.Location = new System.Drawing.Point(0, 0);
            this.toolStripDefault.Name = "toolStripDefault";
            this.toolStripDefault.Size = new System.Drawing.Size(784, 25);
            this.toolStripDefault.TabIndex = 9;
            this.toolStripDefault.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "|----------|";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // switchButton
            // 
            this.switchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.switchButton.Image = ((System.Drawing.Image)(resources.GetObject("switchButton.Image")));
            this.switchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(98, 22);
            this.switchButton.Text = "Switch Activity 1";
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Processed Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Foreground Image";
            // 
            // processedPictureBox
            // 
            this.processedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedPictureBox.Location = new System.Drawing.Point(346, 141);
            this.processedPictureBox.Name = "processedPictureBox";
            this.processedPictureBox.Size = new System.Drawing.Size(374, 373);
            this.processedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedPictureBox.TabIndex = 5;
            this.processedPictureBox.TabStop = false;
            // 
            // foregroundPictureBox
            // 
            this.foregroundPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foregroundPictureBox.Location = new System.Drawing.Point(96, 113);
            this.foregroundPictureBox.Name = "foregroundPictureBox";
            this.foregroundPictureBox.Size = new System.Drawing.Size(187, 186);
            this.foregroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foregroundPictureBox.TabIndex = 6;
            this.foregroundPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cameraComboBox);
            this.panel1.Controls.Add(this.processButton);
            this.panel1.Controls.Add(this.firstTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.modeLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(347, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 81);
            this.panel1.TabIndex = 11;
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.Enabled = false;
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Location = new System.Drawing.Point(87, 33);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(100, 21);
            this.cameraComboBox.TabIndex = 3;
            this.cameraComboBox.SelectionChangeCommitted += new System.EventHandler(this.cameraComboBox_SelectionChangeCommitted);
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundPictureBox.Location = new System.Drawing.Point(96, 328);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(187, 186);
            this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPictureBox.TabIndex = 6;
            this.backgroundPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Background Image";
            // 
            // ActivityTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStripDefault);
            this.Controls.Add(this.toolStripDefault);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processedPictureBox);
            this.Controls.Add(this.backgroundPictureBox);
            this.Controls.Add(this.foregroundPictureBox);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ActivityTwoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Image Processor - Activity 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActivityTwoForm_FormClosed);
            this.statusStripDefault.ResumeLayout(false);
            this.statusStripDefault.PerformLayout();
            this.toolStripDefault.ResumeLayout(false);
            this.toolStripDefault.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.StatusStrip statusStripDefault;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ToolStripDropDownButton modeToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStrip toolStripDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox processedPictureBox;
        private System.Windows.Forms.PictureBox foregroundPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openForegroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBackgroundToolStripMenuItem;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton switchButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openCameraToolStripMenuItem;
        private System.Windows.Forms.ComboBox cameraComboBox;
        private System.Windows.Forms.ToolStripMenuItem liveSubtractionToolStripMenuItem;
    }
}