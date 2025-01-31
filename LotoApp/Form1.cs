namespace LotoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num1, num2, num3, num4;
            num1 = rnd.Next(1, 10);
            num2 = rnd.Next(1, 10);
            num3 = rnd.Next(1, 10);
            num4 = rnd.Next(1, 10);

            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();
            label4.Text = num4.ToString();

            int guess1, guess2, guess3, guess4;

            guess1 = int.Parse(maskedTextBox1.Text);
            guess2 = int.Parse(maskedTextBox3.Text);
            guess3 = int.Parse(maskedTextBox2.Text);
            guess4 = int.Parse(maskedTextBox4.Text);

            if (num1 == guess1)
            {
                maskedTextBox1.BackColor = Color.Green;
            }
            else
            {
                maskedTextBox1.BackColor = Color.Red;
            }
            if (num2 == guess2)
            {
                maskedTextBox3.BackColor = Color.Green;
            }
            else
            {
                maskedTextBox3.BackColor = Color.Red;
            }
            if (num3 == guess3)
            {
                maskedTextBox2.BackColor = Color.Green;
            }
            else
            {
                maskedTextBox2.BackColor = Color.Red;
            }
            if (num4 == guess4)
            {
                maskedTextBox4.BackColor = Color.Green;
            }
            else
            {
                maskedTextBox4.BackColor = Color.Red;
            }
        }
    }
}
