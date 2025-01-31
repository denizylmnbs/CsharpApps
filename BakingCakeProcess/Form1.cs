namespace BakingCakeProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;

            if (progressBar4.Value % 20 == 0)
            {
                label1.BackColor = Color.Red;
            }
            else { label1.BackColor = Color.White; }

            if (progressBar4.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 20;

            if (progressBar1.Value % 40 == 0)
            {
                label2.BackColor = Color.Red;
            }
            else { label2.BackColor = Color.White; }

            if (progressBar1.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;

            if (progressBar2.Value % 20 == 0)
            {
                label3.BackColor = Color.Red;
            }
            else { label3.BackColor = Color.White; }

            if (progressBar2.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 5;

            if (progressBar3.Value % 20 == 0)
            {
                label4.BackColor = Color.Red;
            }
            else { label4.BackColor = Color.White; }

            if (progressBar3.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Your cake is ready.");
            }
        }
    }
}
