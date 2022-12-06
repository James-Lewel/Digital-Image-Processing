namespace DIP
{
    partial class formDefault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDefault));
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.processedPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripDefault = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.modeToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.basicCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripDefault = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.processButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
            this.toolStripDefault.SuspendLayout();
            this.statusStripDefault.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPictureBox.Location = new System.Drawing.Point(12, 141);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(374, 373);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // processedPictureBox
            // 
            this.processedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedPictureBox.Location = new System.Drawing.Point(398, 141);
            this.processedPictureBox.Name = "processedPictureBox";
            this.processedPictureBox.Size = new System.Drawing.Size(374, 373);
            this.processedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedPictureBox.TabIndex = 0;
            this.processedPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Processed Image";
            // 
            // toolStripDefault
            // 
            this.toolStripDefault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.modeToolStripButton,
            this.toolStripSeparator2});
            this.toolStripDefault.Location = new System.Drawing.Point(0, 0);
            this.toolStripDefault.Name = "toolStripDefault";
            this.toolStripDefault.Size = new System.Drawing.Size(784, 25);
            this.toolStripDefault.TabIndex = 2;
            this.toolStripDefault.Text = "toolStrip1";
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
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openFileToolStripMenuItem.Text = "Open";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveFileToolStripMenuItem.Text = "Save";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // modeToolStripButton
            // 
            this.modeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modeToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicCopyToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.colorInversionToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.modeToolStripButton.Enabled = false;
            this.modeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("modeToolStripButton.Image")));
            this.modeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modeToolStripButton.Name = "modeToolStripButton";
            this.modeToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.modeToolStripButton.Text = "Mode";
            // 
            // basicCopyToolStripMenuItem
            // 
            this.basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            this.basicCopyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.basicCopyToolStripMenuItem.Text = "Basic Copy";
            this.basicCopyToolStripMenuItem.Click += new System.EventHandler(this.basicCopyToolStripMenuItem_Click);
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // colorInversionToolStripMenuItem
            // 
            this.colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            this.colorInversionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorInversionToolStripMenuItem.Text = "Color Inversion";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStripDefault
            // 
            this.statusStripDefault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStripDefault.Location = new System.Drawing.Point(0, 539);
            this.statusStripDefault.Name = "statusStripDefault";
            this.statusStripDefault.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStripDefault.Size = new System.Drawing.Size(784, 22);
            this.statusStripDefault.TabIndex = 3;
            this.statusStripDefault.Text = "statusStrip1";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.processButton);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.modeLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(399, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 81);
            this.panel1.TabIndex = 4;
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
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(87, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(87, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Second Value";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Value";
            // 
            // formDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStripDefault);
            this.Controls.Add(this.toolStripDefault);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processedPictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "formDefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Image Processor";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
            this.toolStripDefault.ResumeLayout(false);
            this.toolStripDefault.PerformLayout();
            this.statusStripDefault.ResumeLayout(false);
            this.statusStripDefault.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox processedPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStripDefault;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStripDefault;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton modeToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem basicCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorInversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
    }
}

