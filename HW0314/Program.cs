using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0314
{
    class Program
    {
        static void Main(string[] args)
        {
            int score, total = 0;
            int count = 0;
            int max=-1, min=101;

            do
            {
                Console.Write("score=");
                score = Convert.ToInt32(Console.ReadLine());
                if (score >= 0)
                {
                    if (score > max) max = score;
                    if (score < min) min = score;
                    total += score;
                    count++;
                }
            } while (score >= 0);
            Console.WriteLine("Total = " + total.ToString());
            Console.WriteLine("Average = " + (total / (Convert.ToDouble(count))).ToString());
            Console.WriteLine("Max = " + max.ToString());
            Console.WriteLine("Min = " + min.ToString());
            Console.ReadLine();
        }
    }
}
