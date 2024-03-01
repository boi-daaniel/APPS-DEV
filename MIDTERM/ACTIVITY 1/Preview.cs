using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Activity_1
{
    public partial class Preview : Form
    {
        private char Operator;
        private double Operand;
        private double total;
        public Preview(char Operator, double Operand)
        {
            InitializeComponent();
            this.Operator = Operator;
            this.Operand = Operand;
        }

        public void DoNextOperation(char Operator, double Operand)
        {
                switch (Operator)
                {
                    case '+':
                        total += Operand;
                        listResult.Items.Add($"{Operator} {Operand}");
                        listResult.Items.Add($"result so far is {total.ToString("N1")}");
                        break;
                    case '-':
                        total -= Operand;
                        listResult.Items.Add($"{Operator} {Operand}");
                        listResult.Items.Add($"the result so far is {total.ToString("N1")}");
                        break;
                    case '*':
                        total *= Operand;
                        listResult.Items.Add($"{Operator} {Operand}");
                        listResult.Items.Add($"the result so far is {total.ToString("N1")}");
                        break;
                    case '/':
                        total /= Operand;
                        listResult.Items.Add($"{Operator} {Operand}");
                        listResult.Items.Add($"the result so far is {total.ToString("N1")}");
                        break;
                    case '^':
                        
                    total = Math.Pow(total, Operand);
                        listResult.Items.Add($"{Operator} {Operand}");
                        listResult.Items.Add($"the result so far is {total.ToString("N1")}");
                        break;
                    case 'q':
                        listResult.Items.Add($"{Operator} {Operand}");
                        listResult.Items.Add($"Final result is {total.ToString("N1")}");
                        break;
                    default:
                        listResult.Items.Add("Invalid");
                        break;
                }
        }
    }
}
