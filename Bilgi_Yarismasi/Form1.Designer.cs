namespace Bilgi_Yarismasi
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSoruNo = new Label();
            lblDogru = new Label();
            lblYanlıs = new Label();
            button2 = new Button();
            button5 = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 299);
            button1.Name = "button1";
            button1.Size = new Size(368, 64);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(51, 368);
            button3.Name = "button3";
            button3.Size = new Size(368, 64);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(425, 368);
            button4.Name = "button4";
            button4.Size = new Size(368, 64);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(831, 100);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 4;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(848, 132);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 5;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(849, 159);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 6;
            label3.Text = "Yanlış:";
            // 
            // lblSoruNo
            // 
            lblSoruNo.AutoSize = true;
            lblSoruNo.Location = new Point(924, 100);
            lblSoruNo.Name = "lblSoruNo";
            lblSoruNo.Size = new Size(53, 21);
            lblSoruNo.TabIndex = 7;
            lblSoruNo.Text = "label4";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(924, 132);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(53, 21);
            lblDogru.TabIndex = 8;
            lblDogru.Text = "label5";
            // 
            // lblYanlıs
            // 
            lblYanlıs.AutoSize = true;
            lblYanlıs.Location = new Point(924, 159);
            lblYanlıs.Name = "lblYanlıs";
            lblYanlıs.Size = new Size(53, 21);
            lblYanlıs.TabIndex = 9;
            lblYanlıs.Text = "label6";
            // 
            // button2
            // 
            button2.Location = new Point(425, 298);
            button2.Name = "button2";
            button2.Size = new Size(368, 64);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(848, 212);
            button5.Name = "button5";
            button5.Size = new Size(222, 38);
            button5.TabIndex = 10;
            button5.Text = "Sonraki";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(51, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(742, 264);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(817, 298);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(969, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(698, 484);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(767, 484);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 630);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button5);
            Controls.Add(lblYanlıs);
            Controls.Add(lblDogru);
            Controls.Add(lblSoruNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSoruNo;
        private Label lblDogru;
        private Label lblYanlıs;
        private Button button2;
        private Button button5;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}