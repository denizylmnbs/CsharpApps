namespace Cinema_Cafeteria_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ticketPrice = 5;
        double popcornPrice = 2;
        double cokePrice = 1.5;
        double waterPrice = 1;
        double ticketCount;
        double popcornCount;
        double cokeCount;
        double waterCount;


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ticketCount = Convert.ToDouble(txtTicket.Text);
            popcornCount = Convert.ToDouble(txtPopcorn.Text);
            cokeCount = Convert.ToDouble(txtCoke.Text);
            waterCount = Convert.ToDouble(txtWater.Text);

            double ticketTotalPrice = ticketPrice * ticketCount;
            double popcornTotalPrice = popcornPrice * popcornCount;
            double cokeTotalPrice = cokePrice * cokeCount;
            double waterTotalPrice = waterPrice * waterCount;

            double totalPrice = ticketTotalPrice + popcornTotalPrice + cokeTotalPrice + waterTotalPrice;   
            lblCashout.Text = $"{totalPrice} $";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCoke.Text = "0";
            txtPopcorn.Text = "0";
            txtTicket.Text = "0";
            txtWater.Text = "0";

            lblCashout.Text = "0 $";
        }
    }
}
