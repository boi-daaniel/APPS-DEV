namespace YearBonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double year = Convert.ToDouble(txt1.Text);
            double salary = Convert.ToDouble(txt2.Text);

            double total = 0;
            double finalAmount = 0;
            string percent = "";
            Preview show = new Preview();


            if (year == 1 || year == 1.5)
            {
                total = salary * 0.1;
                finalAmount = salary + total;
                percent = "10% of salary";
                show.setDisplay(year, percent, finalAmount);
            }
            else if (year >= 2 && year <= 5)
            {
                total = salary * 0.2;
                finalAmount = salary + total;
                percent = "20% of salary";
                show.setDisplay(year, percent, finalAmount);
            }
            else if (year > 5 && year <= 10)
            {
                total = salary * 0.5;
                finalAmount = salary + total;
                percent = "50% of salary";
                show.setDisplay(year, percent, finalAmount);
            }
            else if (year >= 11)
            {
                total = salary * 0.75;
                finalAmount = salary + total;
                percent = "75% of salary";
                show.setDisplay(year, percent, finalAmount);
            }
            else
            {
                finalAmount = salary;
                percent = "No Bonus";
                show.setDisplay(year, percent, finalAmount);
            }

            show.Show();
        }
    }
}
