namespace Exercise2WF
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int lengthInCentimeters = int.Parse(txt1.Text);
                double lengthInInches = Math.Round(lengthInCentimeters / 2.54);

                int yards = (int)(lengthInInches / 36);
                int feet = (int)((lengthInInches % 36) / 12);
                int inches = (int)(lengthInInches % 12);

                lbl2.Text = $"{yards} yards, {feet} feet, {inches} inches";
            }
            catch (FormatException)
            {
                lbl2.Text = "Invalid input. Please enter a valid length in centimeters.";
            }
        }

    }
}
