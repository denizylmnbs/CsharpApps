namespace StudentExamCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double average = 0;
            average = (Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text)) / 3;
            listBox1.Items.Add($"Name: {textBox1.Text} {textBox2.Text} Average: {average}");
        }
    }
}
