namespace Act4WF
{
    public partial class Largest : Form
    {
        public Largest()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string input = txt1.Text;

            // Find the positions of spaces
            int space1 = input.IndexOf(' ');
            int space2 = input.LastIndexOf(' ');

            string num1Str = input.Substring(0, space1);
            string num2Str = input.Substring(space1 + 1, space2 - space1 - 1);
            string num3Str = input.Substring(space2 + 1);

            int num1 = int.Parse(num1Str);
            int num2 = int.Parse(num2Str);
            int num3 = int.Parse(num3Str);

            if (num1 > num2 && num1 > num3)
            {
                lbl2.Text = "Num1 is the largest";
            }
            else if (num2 > num1 && num2 > num3)
            {
                lbl2.Text = "Num2 is the largest";
            }
            else
            {
                lbl2.Text = "Num3 is the largest.";
            }
        }
    }
}
