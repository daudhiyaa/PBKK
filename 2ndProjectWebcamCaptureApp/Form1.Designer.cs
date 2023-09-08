namespace _2ndProjectWebcamCaptureApp
{
    partial class WebcamApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxWebcamList = new ComboBox();
            buttonStart = new Button();
            buttonCapture = new Button();
            buttonSaveImage = new Button();
            buttonExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcamList
            // 
            comboBoxWebcamList.FormattingEnabled = true;
            comboBoxWebcamList.Location = new Point(19, 26);
            comboBoxWebcamList.Margin = new Padding(4, 2, 4, 2);
            comboBoxWebcamList.Name = "comboBoxWebcamList";
            comboBoxWebcamList.Size = new Size(283, 40);
            comboBoxWebcamList.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(321, 26);
            buttonStart.Margin = new Padding(4, 2, 4, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(150, 49);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCapture
            // 
            buttonCapture.Location = new Point(490, 26);
            buttonCapture.Margin = new Padding(4, 2, 4, 2);
            buttonCapture.Name = "buttonCapture";
            buttonCapture.Size = new Size(150, 49);
            buttonCapture.TabIndex = 2;
            buttonCapture.Text = "Capture";
            buttonCapture.UseVisualStyleBackColor = true;
            buttonCapture.Click += buttonCapture_Click;
            // 
            // buttonSaveImage
            // 
            buttonSaveImage.Location = new Point(657, 26);
            buttonSaveImage.Margin = new Padding(4, 2, 4, 2);
            buttonSaveImage.Name = "buttonSaveImage";
            buttonSaveImage.Size = new Size(150, 49);
            buttonSaveImage.TabIndex = 3;
            buttonSaveImage.Text = "Save Image";
            buttonSaveImage.UseVisualStyleBackColor = true;
            buttonSaveImage.Click += buttonSaveImage_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(1216, 26);
            buttonExit.Margin = new Padding(4, 2, 4, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(150, 41);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(19, 90);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1348, 627);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(4, 2);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(666, 623);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(678, 2);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(666, 623);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // WebcamApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 740);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonExit);
            Controls.Add(buttonSaveImage);
            Controls.Add(buttonCapture);
            Controls.Add(buttonStart);
            Controls.Add(comboBoxWebcamList);
            Margin = new Padding(4, 2, 4, 2);
            Name = "WebcamApp";
            Text = "Webcam App";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWebcamList;
        private Button buttonStart;
        private Button buttonCapture;
        private Button buttonSaveImage;
        private Button buttonExit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}