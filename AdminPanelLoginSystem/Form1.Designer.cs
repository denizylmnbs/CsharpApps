namespace AdminPanelLoginSystem
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 116);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 37);
            label1.Name = "label1";
            label1.Size = new Size(316, 28);
            label1.TabIndex = 0;
            label1.Text = "Admin Panel Login Screen";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 212);
            label3.Name = "label3";
            label3.Size = new Size(99, 22);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(117, 241);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 301);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
