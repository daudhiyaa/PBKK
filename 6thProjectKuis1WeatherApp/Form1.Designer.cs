namespace _6thProjectKuis1WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            searchTextBox = new TextBox();
            searchBtn = new Button();
            labelCondition = new Label();
            label3 = new Label();
            labelDetails = new Label();
            labelAja = new Label();
            labelSunrise = new Label();
            labelSunset = new Label();
            label8 = new Label();
            labelWindSpeed = new Label();
            label10 = new Label();
            labelPressure = new Label();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(128, 152);
            label1.Name = "label1";
            label1.Size = new Size(81, 45);
            label1.TabIndex = 0;
            label1.Text = "City:";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(215, 152);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(391, 50);
            searchTextBox.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(626, 151);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(150, 46);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.BackColor = Color.Transparent;
            labelCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCondition.ForeColor = SystemColors.ButtonHighlight;
            labelCondition.Location = new Point(303, 365);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(77, 45);
            labelCondition.TabIndex = 3;
            labelCondition.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(632, 374);
            label3.Name = "label3";
            label3.Size = new Size(81, 45);
            label3.TabIndex = 4;
            label3.Text = "City:";
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.BackColor = Color.Transparent;
            labelDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDetails.ForeColor = SystemColors.ButtonHighlight;
            labelDetails.Location = new Point(303, 425);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(77, 45);
            labelDetails.TabIndex = 5;
            labelDetails.Text = "N/A";
            // 
            // labelAja
            // 
            labelAja.AutoSize = true;
            labelAja.BackColor = Color.Transparent;
            labelAja.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAja.ForeColor = SystemColors.ButtonHighlight;
            labelAja.Location = new Point(128, 483);
            labelAja.Name = "labelAja";
            labelAja.Size = new Size(130, 45);
            labelAja.TabIndex = 6;
            labelAja.Text = "Sunrise:";
            // 
            // labelSunrise
            // 
            labelSunrise.AutoSize = true;
            labelSunrise.BackColor = Color.Transparent;
            labelSunrise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSunrise.ForeColor = SystemColors.ButtonHighlight;
            labelSunrise.Location = new Point(303, 483);
            labelSunrise.Name = "labelSunrise";
            labelSunrise.Size = new Size(77, 45);
            labelSunrise.TabIndex = 7;
            labelSunrise.Text = "N/A";
            // 
            // labelSunset
            // 
            labelSunset.AutoSize = true;
            labelSunset.BackColor = Color.Transparent;
            labelSunset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSunset.ForeColor = SystemColors.ButtonHighlight;
            labelSunset.Location = new Point(303, 542);
            labelSunset.Name = "labelSunset";
            labelSunset.Size = new Size(77, 45);
            labelSunset.TabIndex = 9;
            labelSunset.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(128, 542);
            label8.Name = "label8";
            label8.Size = new Size(122, 45);
            label8.TabIndex = 8;
            label8.Text = "Sunset:";
            // 
            // labelWindSpeed
            // 
            labelWindSpeed.AutoSize = true;
            labelWindSpeed.BackColor = Color.Transparent;
            labelWindSpeed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWindSpeed.ForeColor = SystemColors.ButtonHighlight;
            labelWindSpeed.Location = new Point(832, 365);
            labelWindSpeed.Name = "labelWindSpeed";
            labelWindSpeed.Size = new Size(77, 45);
            labelWindSpeed.TabIndex = 11;
            labelWindSpeed.Text = "N/A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(626, 365);
            label10.Name = "label10";
            label10.Size = new Size(200, 45);
            label10.TabIndex = 10;
            label10.Text = "Wind Speed:";
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.BackColor = Color.Transparent;
            labelPressure.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPressure.ForeColor = SystemColors.ButtonHighlight;
            labelPressure.Location = new Point(832, 410);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new Size(77, 45);
            labelPressure.TabIndex = 13;
            labelPressure.Text = "N/A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(626, 410);
            label12.Name = "label12";
            label12.Size = new Size(147, 45);
            label12.TabIndex = 12;
            label12.Text = "Pressure:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(128, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(128, 365);
            label2.Name = "label2";
            label2.Size = new Size(167, 45);
            label2.TabIndex = 15;
            label2.Text = "Condition:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(127, 425);
            label4.Name = "label4";
            label4.Size = new Size(123, 45);
            label4.TabIndex = 16;
            label4.Text = "Details:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1344, 792);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(labelPressure);
            Controls.Add(label12);
            Controls.Add(labelWindSpeed);
            Controls.Add(label10);
            Controls.Add(labelSunset);
            Controls.Add(label8);
            Controls.Add(labelSunrise);
            Controls.Add(labelAja);
            Controls.Add(labelDetails);
            Controls.Add(label3);
            Controls.Add(labelCondition);
            Controls.Add(searchBtn);
            Controls.Add(searchTextBox);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchTextBox;
        private Button searchBtn;
        private Label labelCondition;
        private Label label3;
        private Label labelDetails;
        private Label labelAja;
        private Label labelSunrise;
        private Label labelSunset;
        private Label label8;
        private Label labelWindSpeed;
        private Label label10;
        private Label labelPressure;
        private Label label12;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
    }
}