using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Midterm_Activity_1
{
    public partial class Form1 : Form
    {
        private Preview preview;

        public Form1()
        {
            InitializeComponent();
        }

        public (char Operator, double Operand) scanData()
        {
            char Operator = Convert.ToChar(txtOperator.Text);
            double Operand = Convert.ToDouble(txtOperand.Text);

            return (Operator, Operand);
        }   

        private void btnEnter_Click(object sender, EventArgs e)
        {
            (char Operator, double Operand) = scanData();
            if (preview == null || preview.IsDisposed)
            {
                preview = new Preview(Operator, Operand);
                preview.DoNextOperation(Operator, Operand);
                preview.Show();
            }
            else
            {
                preview.DoNextOperation(Operator, Operand);
            }
        }
    }
}
