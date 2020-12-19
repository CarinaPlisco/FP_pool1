using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 

            int n, i, j, a, b, contor;

            Console.Write("Dati un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dati un interval de tipul [a, b]");

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            contor = 0;

            for (i = a; i <= b; i++)
            { 
                    if (i % n == 0)
                    {
                        contor++;
                    } 
            }
            Console.WriteLine("Intervalul are {0} numere integi divizibile cu {1}", contor, n);
        }
    }
}
