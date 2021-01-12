using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
            int n, k, uc, c; 

            Console.WriteLine("Introduceti un numar n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("A cata cifra de la sfarsitul numarului n doriti sa extrageti? ");
            Console.WriteLine("k = ");
            k = int.Parse(Console.ReadLine());

            c = k;

            do
            {
                uc = n % 10;
                n = n / 10;
                k--;
            }
            while (k > 0);
            
            Console.WriteLine($"A {c}-a cifra de la capat este {uc}");
        }
    }
}
