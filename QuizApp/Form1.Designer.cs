namespace QuizApp
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            lblSoru = new Label();
            lblDogru = new Label();
            label4 = new Label();
            label5 = new Label();
            lblYanlis = new Label();
            label7 = new Label();
            label8 = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(550, 212);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(590, 62);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Soru No:";
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(649, 62);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(13, 15);
            lblSoru.TabIndex = 2;
            lblSoru.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(649, 77);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(13, 15);
            lblDogru.TabIndex = 3;
            lblDogru.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 77);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Doğru:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(603, 92);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 5;
            label5.Text = "Yanlış:";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(649, 92);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(13, 15);
            lblYanlis.TabIndex = 6;
            lblYanlis.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 426);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 7;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 426);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 8;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // btnA
            // 
            btnA.Location = new Point(7, 243);
            btnA.Name = "btnA";
            btnA.Size = new Size(75, 32);
            btnA.TabIndex = 9;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(163, 243);
            btnB.Name = "btnB";
            btnB.Size = new Size(76, 32);
            btnB.TabIndex = 10;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(315, 243);
            btnC.Name = "btnC";
            btnC.Size = new Size(80, 32);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(470, 243);
            btnD.Name = "btnD";
            btnD.Size = new Size(80, 32);
            btnD.TabIndex = 12;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(590, 127);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(72, 37);
            btnSonraki.TabIndex = 13;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(580, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 77);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(711, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 77);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 299);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblYanlis);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblDogru);
            Controls.Add(lblSoru);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Label lblSoru;
        private Label lblDogru;
        private Label label4;
        private Label label5;
        private Label lblYanlis;
        private Label label7;
        private Label label8;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
