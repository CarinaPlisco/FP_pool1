using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

            float n, k;

            Console.WriteLine("n = ");
            n = float.Parse(Console.ReadLine());
            Console.WriteLine("k = ");
            k = float.Parse(Console.ReadLine());

            if(n % k == 0 )
            {
                Console.WriteLine($"{n} se divide cu {k}");
            }
            else
            { 
                Console.WriteLine($"{n} nu se divide cu {k}");
            }
        }
    } 
}
