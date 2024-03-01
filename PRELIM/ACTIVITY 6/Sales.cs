using System.Globalization;

namespace Sales
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        public void setValues(double commission, string percent, double totalAmount) 
        {
            lbl1.Text = percent;
            lbl2.Text = "Php " + commission.ToString("N2");
            lbl3.Text = "Php " + totalAmount.ToString("N2");
        }
    }
}
