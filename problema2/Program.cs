using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
            //Tratati toate cazurile posibile. 

            double a, b, c, delta, x1, x2;

            Console.WriteLine("Introduceti numerele a, b, c din ecuatia ax^2 + bx + c = 0 ");

            Console.WriteLine("a = ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c = ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ecuatia formata este {0}x^2 + {1}x + {2} = 0", a,b,c);

            delta = Math.Sqrt(b * b - 4 * a * c);

            x1 = (-b - delta) / (2 * a);
            x2 = (-b + delta) / (2 * a);
            x1 = Math.Round(x1, 2);
            x2 = Math.Round(x2, 2);

            if (delta > 0)
            {
                Console.WriteLine("Ecuatia are doua solutii: ");
                Console.WriteLine(" x1 = {0}", x1);
                Console.WriteLine(" x2 = {0}", x2);
            }
            else
            {
                if (delta == 0)
                {
                    Console.WriteLine($" Necunoscuta x este {0} ", x1);
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are solutii care sa apartina lui R. ");

                }
            } 
        }
    }
}
