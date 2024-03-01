namespace Act3WF
{
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double discountRate = 0.10;

            double price = Convert.ToInt32(txt1.Text);
            if (price > 1000)
            {
                double discount = price * discountRate;
                txt2.Text = discount.ToString("N2");
            }
            else
            {
                txt2.Text = "No Discount";
            }
        }
    }
}
