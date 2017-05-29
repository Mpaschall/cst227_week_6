using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double interest = 0.05;
            int years = 0;
            double initialAmount = 1000;
            double currentAmount = 0;
            double endingAmount = 2000;

            while (currentAmount <= 2000)
            {
               if(currentAmount == 0)
                {
                    currentAmount = ((initialAmount * interest) + initialAmount);
                    years++;
                }
               else if (currentAmount != 0)
                {
                    currentAmount = ((currentAmount * interest) + currentAmount);
                    years++;
                }
            }
            Console.WriteLine("With $1000 it will take " 
                + years + " years with 5% interest to get to $2000.");

        }
    }
}
