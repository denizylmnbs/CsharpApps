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
                btnSonraki.Text = "Baþlat";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;

            }
            else if (soruNo == 1)
            {
                richTextBox1.Text = "Türkiye'nin baþkenti neresidir?";
                btnA.Text = "Ankara";
                btnB.Text = "Ýstanbul";
                btnC.Text = "Ýzmir";
                btnD.Text = "Bursa";
                label7.Text = "Ankara";
            }
            else if (soruNo == 2)
            {
                richTextBox1.Text = "Türkiye'nin en kalabalýk þehri neresidir?";
                btnA.Text = "Ankara";
                btnB.Text = "Ýstanbul";
                btnC.Text = "Ýzmir";
                btnD.Text = "Bursa";
                label7.Text = "Ýstanbul";
            }
            else if (soruNo == 3)
            {
                richTextBox1.Text = "Türkiye'nin en büyük gölü hangisidir?";
                btnA.Text = "Van Gölü";
                btnB.Text = "Beyþehir Gölü";
                btnC.Text = "Tuz Gölü";
                btnD.Text = "Gölcük Gölü";
                label7.Text = "Van Gölü";
                btnSonraki.Text = "Sonuçlar";
            }
             else if (soruNo == 4)
            {
                MessageBox.Show("Doðru: " + dogru + "\n" + "Yanlýþ: " + yanlis);
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
