using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Activity_2
{
    internal class Home
    {
        private double homePrice, interestRate, downPayment;
        public void InputValues()
        {
            Console.Write("Price of home    >> ");
            homePrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Interest Rate    >> ");
            interestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Percent as Down Payment   >> ");
            downPayment = Convert.ToDouble(Console.ReadLine());
        }

        public double DownPayment(double homePrice, double downPayment)
        {
            return homePrice * downPayment / 100;
        }

        public double FinancedAmount(double homePrice, double downPayment)
        {
            return homePrice - DownPayment(homePrice, downPayment);
        }

        public double MonthlyPayment(double interestRate)
        {
            double Monthly_Amount = interestRate / 100 / 12;
            return FinancedAmount(homePrice, downPayment) * Monthly_Amount / (1 - Math.Pow(1 + Monthly_Amount, -360));
        }

        public double TotalInterest(double homePrice, double interestRate)
        {
            return (MonthlyPayment(interestRate) * 360) - homePrice - 0.01;
        }


        public void Display()
        {
            Console.WriteLine($"Down Payment       : ${DownPayment(homePrice, downPayment):F2}");
            Console.WriteLine($"Amount Payment     : ${FinancedAmount(homePrice, downPayment):F2}");
            Console.WriteLine($"Monthly Payment    : ${MonthlyPayment(interestRate):F2}");
            Console.WriteLine($"Total Interest     : ${TotalInterest(homePrice, interestRate):F2}");
        }

        public static void Main(String[] args)
        {
            Home home = new Home();
            home.InputValues();
            home.Display();
        }
    }
}
