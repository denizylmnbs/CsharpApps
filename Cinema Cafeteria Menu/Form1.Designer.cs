namespace Cinema_Cafeteria_Menu
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtWater = new TextBox();
            txtCoke = new TextBox();
            txtPopcorn = new TextBox();
            txtTicket = new TextBox();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            lblCashout = new Label();
            button2 = new Button();
            button1 = new Button();
            label11 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 99);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(243, 32);
            label1.Name = "label1";
            label1.Size = new Size(284, 29);
            label1.TabIndex = 0;
            label1.Text = "C# Cinema Cafeteria Menu";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Khaki;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 275);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Price List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(53, 176);
            label5.Name = "label5";
            label5.Size = new Size(72, 18);
            label5.TabIndex = 3;
            label5.Text = "Water: 1$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(56, 146);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 2;
            label4.Text = "Coke: 1.5$";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(33, 114);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 1;
            label3.Text = "Popcorn: 2$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(49, 81);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 0;
            label2.Text = "Ticket: 5$";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSeaGreen;
            groupBox2.Controls.Add(txtWater);
            groupBox2.Controls.Add(txtCoke);
            groupBox2.Controls.Add(txtPopcorn);
            groupBox2.Controls.Add(txtTicket);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(327, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 275);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order";
            // 
            // txtWater
            // 
            txtWater.Location = new Point(82, 176);
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(100, 29);
            txtWater.TabIndex = 11;
            // 
            // txtCoke
            // 
            txtCoke.Location = new Point(82, 144);
            txtCoke.Name = "txtCoke";
            txtCoke.Size = new Size(100, 29);
            txtCoke.TabIndex = 10;
            // 
            // txtPopcorn
            // 
            txtPopcorn.Location = new Point(82, 109);
            txtPopcorn.Name = "txtPopcorn";
            txtPopcorn.Size = new Size(100, 29);
            txtPopcorn.TabIndex = 9;
            // 
            // txtTicket
            // 
            txtTicket.Location = new Point(82, 74);
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(100, 29);
            txtTicket.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(24, 176);
            label6.Name = "label6";
            label6.Size = new Size(52, 18);
            label6.TabIndex = 7;
            label6.Text = "Water:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(20, 81);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 4;
            label9.Text = "Ticket:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(27, 146);
            label7.Name = "label7";
            label7.Size = new Size(49, 18);
            label7.TabIndex = 6;
            label7.Text = "Coke:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(4, 114);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 5;
            label8.Text = "Popcorn:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Thistle;
            groupBox3.Controls.Add(lblCashout);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(588, 127);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 275);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cashout";
            // 
            // lblCashout
            // 
            lblCashout.AutoSize = true;
            lblCashout.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCashout.Location = new Point(73, 81);
            lblCashout.Name = "lblCashout";
            lblCashout.Size = new Size(24, 18);
            lblCashout.TabIndex = 7;
            lblCashout.Text = "0$";
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(67, 211);
            button2.Name = "button2";
            button2.Size = new Size(89, 26);
            button2.TabIndex = 6;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(67, 179);
            button1.Name = "button1";
            button1.Size = new Size(89, 26);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(20, 81);
            label11.Name = "label11";
            label11.Size = new Size(47, 18);
            label11.TabIndex = 4;
            label11.Text = "Total:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtWater;
        private TextBox txtCoke;
        private TextBox txtPopcorn;
        private TextBox txtTicket;
        private Label label6;
        private Label label9;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private Button button1;
        private Label label11;
        private Label lblCashout;
        private Button button2;
    }
}
