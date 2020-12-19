using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati toti divizorii numarului n. 

            int n, i;

            Console.WriteLine("Introduceti un numar:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    Console.WriteLine("{0}", i);
            }
        }
    }
}
