using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test de primalitate: determinati daca un numar n este prim.

            int n, i;

            Console.WriteLine("Introduceti un numar n.");
            Console.WriteLine("n = ");
            n = int.Parse(Console.ReadLine());

            bool prim = true;

            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prim = false;
                    break;
                }
            }

            if (prim)
            {
                Console.WriteLine("Numarul {0} este prim.", n);
            }
            else
            { 
                if (n == 0 || n == 2 || n == 1)
                {
                    Console.WriteLine("Numarul {0} este prim", n);
                }
                else
                {
                    Console.WriteLine("Numarul {0} nu este prim", n);
                }
            }
        }
    }
}
