using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_20
{
    class Warehouse
    {
        int radio, tv, computer, amount;

        public Warehouse()
        {

        }

        public Warehouse(int radio, int tv, int computer)
        {
            this.radio = radio;
            this.tv = tv;
            this.computer = computer;
        }

        public void setRadio(int radio)
        {
            this.radio = radio;
        }

        public void setTv(int tv)
        {
            this.tv = tv;
        }

        public void setComputer(int computer)
        {
            this.computer = computer;
        }

        public int getRadios()
        {
            return radio;
        }

        public int getTv()
        {
            return tv;
        }

        public int getComputer()
        {
            return computer;
        }

        public void removeAmount()
        {
            string option = "";
            Console.WriteLine("What item would you like to remove? radio, tv, computer");
            option = Console.ReadLine();
            if (option == "radio")
            {
                Console.WriteLine("How many?");
                radio -= amount;
            }
            else if (option == "tv")
            {
                Console.WriteLine("How many?");
                tv -= amount;
            }
            else if (option == "computer")
            {
                Console.WriteLine("How many?");
                computer -= amount;
            }
        }

        public void addAmount()
        {
            string option = "";
            Console.WriteLine("What item would you like to add? radio, tv, computer");
            option = Console.ReadLine();
            if (option == "radio")
            {
                Console.WriteLine("How many?");
                amount = Convert.ToInt32(Console.ReadLine());
                radio += amount;
            }
            else if (option == "tv")
            {
                Console.WriteLine("How many?");
                amount = Convert.ToInt32(Console.ReadLine());
                tv += amount;
            }
            else
            {
                Console.WriteLine("How many?");
                amount = Convert.ToInt32(Console.ReadLine());
                computer += amount;
            }
        }
    }
}
