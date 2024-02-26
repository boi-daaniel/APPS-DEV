using System.Xml.Linq;

namespace CustomerDataEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";

            if (rdbMale.Checked) 
                Gender = "Male";
            else 
                Gender = "Female";

            if (chk1.Checked && chk2.Checked)
                Hobby = "Reading and Painting";
            else if (chk1.Checked)
                Hobby = "Reading";
            else if (chk2.Checked)
                Hobby = "Painting";
            else
                Hobby = "No Hobby Selected";


            if (rdbMarried.Checked) 
                Status = "Married";
            else 
                Status = "Single";
            
            Preview customerData = new Preview();

            customerData.SetValues(txt1.Text, cmbCountry.Text, Gender, Hobby, Status);
            customerData.Show();

        }
    }
}
