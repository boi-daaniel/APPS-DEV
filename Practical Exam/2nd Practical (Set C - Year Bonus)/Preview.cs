namespace YearBonus
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }


        public void setDisplay(double year, string percent, double finalAmount) 
        { 
            lblYear.Text = year.ToString();
            lblBonus.Text = percent.ToString();
            lblTotal.Text = "Final Amount: Php " + finalAmount.ToString("N2");
        }


        private void Preview_Load(object sender, EventArgs e)
        {

        }
    }
}
