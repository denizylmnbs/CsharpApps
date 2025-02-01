namespace PersonelKayit
{
    partial class FormIstatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamPersonel = new System.Windows.Forms.Label();
            this.lblEvliPersonel = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblBekarPersonel = new System.Windows.Forms.Label();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.lblOrtalamaMaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evli Personel Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bekar Personel Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ortalama Maaş:";
            // 
            // lblToplamPersonel
            // 
            this.lblToplamPersonel.AutoSize = true;
            this.lblToplamPersonel.Location = new System.Drawing.Point(195, 71);
            this.lblToplamPersonel.Name = "lblToplamPersonel";
            this.lblToplamPersonel.Size = new System.Drawing.Size(18, 18);
            this.lblToplamPersonel.TabIndex = 6;
            this.lblToplamPersonel.Text = "0";
            this.lblToplamPersonel.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblEvliPersonel
            // 
            this.lblEvliPersonel.AutoSize = true;
            this.lblEvliPersonel.Location = new System.Drawing.Point(195, 98);
            this.lblEvliPersonel.Name = "lblEvliPersonel";
            this.lblEvliPersonel.Size = new System.Drawing.Size(18, 18);
            this.lblEvliPersonel.TabIndex = 7;
            this.lblEvliPersonel.Text = "0";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(195, 152);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(18, 18);
            this.lblSehir.TabIndex = 8;
            this.lblSehir.Text = "0";
            // 
            // lblBekarPersonel
            // 
            this.lblBekarPersonel.AutoSize = true;
            this.lblBekarPersonel.Location = new System.Drawing.Point(195, 125);
            this.lblBekarPersonel.Name = "lblBekarPersonel";
            this.lblBekarPersonel.Size = new System.Drawing.Size(18, 18);
            this.lblBekarPersonel.TabIndex = 9;
            this.lblBekarPersonel.Text = "0";
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Location = new System.Drawing.Point(195, 180);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(18, 18);
            this.lblToplamMaas.TabIndex = 10;
            this.lblToplamMaas.Text = "0";
            // 
            // lblOrtalamaMaas
            // 
            this.lblOrtalamaMaas.AutoSize = true;
            this.lblOrtalamaMaas.Location = new System.Drawing.Point(195, 207);
            this.lblOrtalamaMaas.Name = "lblOrtalamaMaas";
            this.lblOrtalamaMaas.Size = new System.Drawing.Size(18, 18);
            this.lblOrtalamaMaas.TabIndex = 11;
            this.lblOrtalamaMaas.Text = "0";
            // 
            // FormIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 330);
            this.Controls.Add(this.lblOrtalamaMaas);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.lblBekarPersonel);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblEvliPersonel);
            this.Controls.Add(this.lblToplamPersonel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormIstatistik";
            this.Text = "FormIstatistik";
            this.Load += new System.EventHandler(this.FormIstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplamPersonel;
        private System.Windows.Forms.Label lblEvliPersonel;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblBekarPersonel;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Label lblOrtalamaMaas;
    }
}