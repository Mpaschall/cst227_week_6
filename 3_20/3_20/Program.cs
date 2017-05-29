using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double entered = 0;
            double total = 0;
            double average = 0;
            int count = 0;
            while (entered >= 0)
            {
                Console.WriteLine("Please input a positive number. negative to quit");
                entered = Convert.ToDouble(Console.ReadLine());
                if (entered >= 0)
                {
                    total += entered;
                    count++;
                }
                else if (entered < 0)
                {
                    average = (total / count);
                    Console.WriteLine("The average is " + average + ".");
                    break;
                }

            }
            
        }
    }
}
