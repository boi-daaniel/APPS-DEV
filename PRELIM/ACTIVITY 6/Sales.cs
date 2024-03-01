namespace Sales
{
    public partial class Sales : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(txt1.Text);
            double text2 = Convert.ToDouble(txt2.Text);
            double text3 = Convert.ToDouble(txt3.Text);

            double TotalSale = text1 + text2 + text3;
            txt4.Text = TotalSale.ToString();

            double commission = 0;
            String percent = "";

            if (chk1.Checked)
            {
                commission = TotalSale * 0.5;
                percent = "50%";
            }
            else if (chk2.Checked)
            {
                commission = TotalSale * 0.1;
                percent = "10%";
            }
            else if (chk3.Checked)
            {
                commission = TotalSale * 0.15;
                percent = "15%";
            }
            else
            {
                percent = "No Percentage Selected";
            }

            double totalAmount = TotalSale + commission;

            Preview result = new Preview();
            result.setValues(commission, percent, totalAmount);
            result.Show();
        }
    }
}
