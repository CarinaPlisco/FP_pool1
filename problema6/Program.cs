using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

            float a, b, c;

            Console.WriteLine("Introduceti cele trei laturi ale triunghiului. Acestea trebuie sa fie numere pozitive. ");
            
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine()); 

            if ((a< b + c) && (b < a + c) && (c < a + b) && (a > 0) && (b > 0) && (c > 0) )
            {
                Console.WriteLine($"Laturile {a}, {b} si {c} pot forma un triunghi.");
                if ( (a == b) && (a == c) )
                {
                    Console.WriteLine("Triunghiul format este echilateral.");
                }
                else
                {
                    if ((a == b) && (a == c))
                        Console.WriteLine("Triunghiul format este isoscel.");
                    else
                        Console.WriteLine("Triunghiul format este unul oarecare.");
                }
            } 
            else
            {
                Console.WriteLine($"Laturile {a}, {b} si {c} nu pot forma un triunghi.");
            }
        }
    }
}
