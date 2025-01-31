namespace DiscountCalculator
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bookPrice = 8.0;
            double bookCount = Convert.ToDouble(textBox1.Text);
            double actualPrice = bookCount * bookPrice;
            double discountRate = 0;

            if (bookCount <= 20)
            {
                discountRate = 0.2;
            }
            else if (bookCount <= 40)
            {
                discountRate = 0.4;
            }
            else if (bookCount > 40)
            {
                discountRate = 0.5;
            }

            double discountAmount = actualPrice * discountRate;
            double discountedPrice = actualPrice - discountAmount;

            label10.Text = actualPrice + "$";
            label11.Text = discountedPrice + "$";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
