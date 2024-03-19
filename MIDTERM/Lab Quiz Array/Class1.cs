using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3score
{
    internal class Class1
    {
        public void inputScore()
        {
            string[] name = new string[3];

            for (int i = 0; i < name.Length; i++)
            {
                double scores,average;
                double sum = 0;
                Console.Write($"Enter name[{i+1}]: ");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter scores: ");
                for (int j = 0; j < name.Length; j++)
                {
                    scores = Convert.ToDouble(Console.ReadLine());
                    sum += scores;
                }
                Console.WriteLine($"The sum is: {sum.ToString("N1")}");
                average = sum / name.Length;
                Console.WriteLine($"The average is: {average.ToString("N1")}");
            }
        }
    }
}
