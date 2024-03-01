namespace CustomerDataEntry
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        public void SetValues(string Name, string Country, string Gender, string Hobby, string Status)
        {
            lblName.Text = Name;
            lblCountry.Text = Country;
            lblGender.Text = Gender;
            lblHobby.Text = Hobby;
            lblStatus.Text = Status;
        }
    }
}
