using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.  
  
            float a, b, x;

            Console.Write("numarul a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("numarul b = ");
            b = float.Parse(Console.ReadLine());

            x = -b / a; 

            Console.WriteLine($" {a}x + {b} = 0 ");
            Console.WriteLine($" => x = {x}");
        }
    }
}
