using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int entered = 0;
            int count = 0;
            //array created to allow usage in other programs as needed, not used in this program
            int[] arr = new int[num];
            Console.WriteLine("How many numbers will you input?");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Please enter a number.");
                entered = Convert.ToInt32(Console.ReadLine());
                arr[i] = entered;
                if (entered < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("You entered " + count + " negative numbers.");
        }
    }
}
