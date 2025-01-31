
namespace LotoApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F);
            label1.Location = new Point(84, 62);
            label1.Name = "label1";
            label1.Size = new Size(22, 23);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F);
            label2.Location = new Point(211, 62);
            label2.Name = "label2";
            label2.Size = new Size(22, 23);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F);
            label3.Location = new Point(335, 62);
            label3.Name = "label3";
            label3.Size = new Size(22, 23);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F);
            label4.Location = new Point(458, 62);
            label4.Name = "label4";
            label4.Size = new Size(22, 23);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(229, 148);
            button1.Name = "button1";
            button1.Size = new Size(128, 45);
            button1.TabIndex = 4;
            button1.Text = "LOTO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(67, 88);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(58, 23);
            maskedTextBox1.TabIndex = 5;
            maskedTextBox1.MaskInputRejected += this.maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(316, 88);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(60, 23);
            maskedTextBox2.TabIndex = 6;
            maskedTextBox2.MaskInputRejected += this.maskedTextBox2_MaskInputRejected;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(192, 88);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(61, 23);
            maskedTextBox3.TabIndex = 7;
            maskedTextBox3.MaskInputRejected += this.maskedTextBox3_MaskInputRejected;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(436, 88);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(61, 23);
            maskedTextBox4.TabIndex = 8;
            maskedTextBox4.MaskInputRejected += this.maskedTextBox4_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 314);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
    }
}
