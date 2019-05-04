using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_airway
{
    class Vip : Customer
    {
        public int Num_Flight;

        public void vid(int Num)
        {
            Num_Flight = Num;
        }


        public void data(string x, string z, int d, string y, string t, int flight_Num)
        {
            first = x;
            sec = z;
            this.id = d;
            from = y;
            to = t;
            Num_Flight = flight_Num;
        }

        public void display()
        {
            Console.WriteLine("Your first Name :" + first);
            Console.WriteLine("Your second Name:" + sec);
            Console.WriteLine("Your ID :" + id);
            Console.WriteLine("Your Flight From :" + from);
            Console.WriteLine("Your Flight to :" + to);
            Console.WriteLine("Number your Flight with company :" + Num_Flight);
        }
    }
}
