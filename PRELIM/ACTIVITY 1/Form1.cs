namespace Exercise1WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            double bagsPrice = 5.50;
            double largePrice = 3.00;
            double mediumPrice = 2.50;
            double smallPrice = 2.00;

            try
            {
                int numberOfBags = Convert.ToInt32(txt1.Text);
                int largeBags = Convert.ToInt32(txt3.Text);
                int mediumBags = Convert.ToInt32(txt4.Text);
                int smallBags = Convert.ToInt32(txt5.Text);

                double totalCost = (largeBags * largePrice) + (mediumBags * mediumPrice) + (smallBags * smallPrice) + (numberOfBags * bagsPrice);

                lbl6.Text = $"Your total cost is: ${totalCost:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for each input.");
            }


        }

    }
}
