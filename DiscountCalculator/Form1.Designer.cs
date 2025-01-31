namespace DiscountCalculator
{
    partial class Form1
    {
        private const string V = "Discount Rates:";

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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Book Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(680, 18);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 2;
            label3.Text = "8$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(608, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 3;
            label2.Text = V;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 82);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 4;
            label4.Text = "0-20 Books: 20%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 110);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 5;
            label5.Text = "21-40 Books: 40%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 138);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 6;
            label6.Text = "41+ Books: 50%";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 133);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 8;
            label7.Text = "Book Count:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(255, 173);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 9;
            label8.Text = "Actual Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 203);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 10;
            label9.Text = "Price With Discount: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(334, 173);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(378, 203);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(253, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button1;
    }
}
