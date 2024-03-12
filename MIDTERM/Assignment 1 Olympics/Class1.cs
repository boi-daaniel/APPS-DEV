using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceTest
{
    internal class Class1
    {

        public void inputScore()
        {
            double totalScores = 0;
            double[] contestantsScore = new double[8];

            for (int i = 0; i < contestantsScore.Length; i++)
            {
                Console.Write($"Enter the score of judge [{i + 1}] :");
                contestantsScore[i] = Convert.ToDouble(Console.ReadLine());
                totalScores += contestantsScore[i];
            }

            totalScores -= contestantsScore.Max();
            totalScores -= contestantsScore.Min();
            Console.WriteLine($"The contestant receives a total of {totalScores.ToString("N2")} points.");
        }

    }
}
