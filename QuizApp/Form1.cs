namespace QuizApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int soruNo = 0, dogru = 0, yanlis = 0;

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soruNo++;
            lblSoru.Text = soruNo.ToString();

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            if (soruNo == 0)
            {
                btnSonraki.Text = "Ba�lat";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;

            }
            else if (soruNo == 1)
            {
                richTextBox1.Text = "T�rkiye'nin ba�kenti neresidir?";
                btnA.Text = "Ankara";
                btnB.Text = "�stanbul";
                btnC.Text = "�zmir";
                btnD.Text = "Bursa";
                label7.Text = "Ankara";
            }
            else if (soruNo == 2)
            {
                richTextBox1.Text = "T�rkiye'nin en kalabal�k �ehri neresidir?";
                btnA.Text = "Ankara";
                btnB.Text = "�stanbul";
                btnC.Text = "�zmir";
                btnD.Text = "Bursa";
                label7.Text = "�stanbul";
            }
            else if (soruNo == 3)
            {
                richTextBox1.Text = "T�rkiye'nin en b�y�k g�l� hangisidir?";
                btnA.Text = "Van G�l�";
                btnB.Text = "Bey�ehir G�l�";
                btnC.Text = "Tuz G�l�";
                btnD.Text = "G�lc�k G�l�";
                label7.Text = "Van G�l�";
                btnSonraki.Text = "Sonu�lar";
            }
             else if (soruNo == 4)
            {
                MessageBox.Show("Do�ru: " + dogru + "\n" + "Yanl��: " + yanlis);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label8.Text = btnA.Text;
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            if (label8.Text == label7.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label8.Text = btnB.Text;
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            if (label8.Text == label7.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label8.Text = btnC.Text;
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            if (label8.Text == label7.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label8.Text = btnD.Text;
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            if (label8.Text == label7.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
