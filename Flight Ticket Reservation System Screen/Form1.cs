namespace Flight_Ticket_Reservation_System_Screen
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

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Flight Information // From: {comboBox1.Text} To: {comboBox2.Text}, Date: {dateTimePicker1.Text}, Time: {maskedTextBox1.Text}");
            listBox1.Items.Add($"// Passenger Information // Full Name: {textBox1.Text}, Identity Number: {maskedTextBox2.Text}, Phone Number: {maskedTextBox3.Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstCity = comboBox1.Text;
            string secondCity = comboBox2.Text;

            comboBox1.Text = secondCity;
            comboBox2.Text = firstCity;
        }
    }
}
