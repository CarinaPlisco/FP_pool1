using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau 3 numere. Sa se afiseze in ordine crescatoare. 

            int x, y, z, a, b, c, aux;

            Console.WriteLine("Introduceti 3 numere pentru a le afisa in ordine crescatoare.");

            Console.Write(" x = ");
            x = int.Parse(Console.ReadLine());

            Console.Write(" y = ");
            y = int.Parse(Console.ReadLine());

            Console.Write(" z = ");
            z = int.Parse(Console.ReadLine());

            a = x;
            b = y;
            c = z;

            aux = 0;

            if ( x > y )
            {
                aux = x;
                x = y;
                y = aux;
            }
            if ( x > z)
            {
                aux = x;
                x = z;
                z = aux;
            }
            if ( y > z)
            {
                aux = y;
                y = z;
                z = aux;
            }
            Console.WriteLine($"Numerele {a}, {b} si {c} in ordine crescatoare sunt {x}, {y}, {z}.");

        }
    }
}
