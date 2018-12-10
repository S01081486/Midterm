using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i = 15;
                Boolean keeplooping = true;
                while (keeplooping)
                {
                    if (i <= 14)

                        keeplooping = false;
                    i++;
                    Console.WriteLine(i);
                }
            }

            {
                int i = 2;
                while (i <= 128) ;
                {
                    {
                        if ((i % 2) == 0)
                        {
                            Console.WriteLine("({0})", i);
                        }
                        else if ((i % 2) != 0)
                        {
                            Console.Write("");
                        }
                        i *= 2;
                    }
                }
            }
            {
                {
                     string j = ",";
                     int i;
                     for (i = 49; i >= 1; --i)
                     {
                        Console.Write(i);
                        if (i >= 2)
                        {
                            Console.Write(j);
                        }
                     }
                }
            }
            {
                int i = 1;
                while (i <= 49)
                {
                    {
                        if ((i % 2) == 0)
                        {
                            Console.Write(" ");
                        }
                        else if ((i % 2) != 0)
                        {
                            Console.Write(i);
                        }
                        i++;
                    }
                }
            }
            {
                int n = 8;
                int i = 10; // initialize
                do
                {
                    Console.Write("*");
                    i++; // update
                } while (i < n); // test condition
            }
        }
    }
}

// 