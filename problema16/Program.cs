using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

            int x, y, z, u, w, max, min, i;

            Console.WriteLine("Introduceti 5 numere pentru a le afisa in ordine crescatoare.");

            Console.Write(" x = ");
            x = int.Parse(Console.ReadLine());

            Console.Write(" y = ");
            y = int.Parse(Console.ReadLine());

            Console.Write(" z = ");
            z = int.Parse(Console.ReadLine());

            Console.Write(" u = ");
            u = int.Parse(Console.ReadLine());

            Console.Write(" w = ");
            w = int.Parse(Console.ReadLine());

            min = 16000;

            if (x < min) min = x;
            if (y < min) min = y;
            if (z < min) min = z;
            if (u < min) min = u;
            if (w < min) min = w;

            max = 0;

            if (x > max) max = x;
            if (y > max) max = y;
            if (z > max) max = z;
            if (u > max) max = u;
            if (w > max) max = w;

            Console.WriteLine("Numere in ordine crescatoare sunt : ");

            for ( i = min; i <= max; i++)
            {
                if (x == i)
                    Console.WriteLine($" {x}");
                if (y == i)
                    Console.WriteLine($" {y}");
                if (z == i)
                    Console.WriteLine($" {z}");
                if (u == i)
                    Console.WriteLine($" {u}");
                if (w == i) 
                    Console.WriteLine($" {w}");
            }
        }
    }
}
