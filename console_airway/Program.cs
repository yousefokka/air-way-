using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_airway
{
    class Program
    {
        static void Main(string[] args)
        {
            Vip B = new Vip();
            Customer N = new Customer();

            int x;

            while (true)
            {
                Console.WriteLine("Enter 1 if you Vip Customer And Need To Enter the Data ");
                Console.WriteLine("                        *----------------------*                ");
                Console.WriteLine("Enter 2 if you New Customer And Need To Enter the Data");
                Console.WriteLine("                         *----------------------*                ");
                Console.WriteLine(" Enter 3 to display vip Data   ");
                Console.WriteLine("                         *----------------------*                 ");
                Console.WriteLine("Display NEr Customer Data Enter 4 ");
                Console.WriteLine("                          *-----------------------*              ");
                Console.WriteLine("Exit  Enetr 5 ");
                Console.WriteLine("                     * ------------------------------------- *                     ");
                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine("Plese Enter Your Data");

                        Console.WriteLine("Enter you First Name ");
                        string Name1;
                        Name1 = Console.ReadLine();

                        Console.WriteLine("Enter your second name");
                        string Name2;
                        Name2 = Console.ReadLine();

                        Console.WriteLine("Enter you ID");
                        int D;
                        D = int.Parse(Console.ReadLine());
                        Console.WriteLine("Eneter you Flight from");
                        string fr;
                        fr = Console.ReadLine();

                        Console.WriteLine("Enter you Flight To");
                        string t;
                        t = Console.ReadLine();

                        N.data(Name1, Name2, D, fr, t);
                        break;


                    case 2:

                        int ch;
                        Console.WriteLine("Enter 1 if the first flight  2  is oR No ");
                        ch = int.Parse(Console.ReadLine());

                        if (ch == 1)
                        {
                            Console.WriteLine("Happy flight with us ");
                        }
                        else if (ch == 2)
                        {
                            Console.WriteLine("We wich Happy with Us");
                        }

                        Console.WriteLine("Plese Enter Your Data");

                        Console.WriteLine("Enter you First Name ");
                        string Name3;
                        Name3 = Console.ReadLine();

                        Console.WriteLine("Enter your second name");
                        string Name4;
                        Name4 = Console.ReadLine();

                        Console.WriteLine("Enter you ID");
                        int DD;
                        DD = int.Parse(Console.ReadLine());
                        Console.WriteLine("Eneter you Flight from");
                        string fro;
                        fro = Console.ReadLine();
                        Console.WriteLine("Enter you Flight To");
                        string too;
                        too = Console.ReadLine();

                        Console.WriteLine("Plese  Enter your Flight Nuber");
                        int NN;
                        NN = int.Parse(Console.ReadLine());
                        B.data(Name3, Name4, DD, fro, too, NN);
                        break;

                    case 3:
                        N.display();
                        break;

                    case 4:
                        B.display();
                        break;

                    case 5:
                        break;
                }
            }
        }
    }
}
