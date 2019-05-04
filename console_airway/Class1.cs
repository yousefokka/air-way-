using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_airway
{
    class Customer
    {
        private string First_Name;
        private string second_Name;
        private int ID;
        private string Fly_from;
        private string Fly_to;




        public string first
        {
            get { return First_Name; }
            set { First_Name = value; }
        }
        public string sec
        {
            get { return second_Name; }
            set { second_Name = value; }
        }
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string from
        {
            get { return Fly_from; }
            set { Fly_from = value; }
        }
        public string to
        {
            get { return Fly_to; }
            set { Fly_to = value; }
        }

        public void data(string F_Name, string S_Name, int iD, string from, string to)
        {
            First_Name = F_Name;
            second_Name = S_Name;
            ID = iD;
            Fly_from = from;
            Fly_to = to;
        }
        public void display()
        {
            Console.WriteLine("Your first Name :" + First_Name);
            Console.WriteLine("Your second Name:" + second_Name);
            Console.WriteLine("Your ID :" + ID);
            Console.WriteLine("Your Flight From :" + Fly_from);
            Console.WriteLine("Your Flight to :" + Fly_to);
        }

        public void check(int choise)
        {

            if (choise == 1)
            {
                Console.WriteLine("We Wish Happy flight with Us");
            }
            else if (choise == 2)
            {
                Console.WriteLine("Happy again :)");
            }
        }

    }
}
