using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati in ordine inversa cifrele unui numar n. 

            int n, ogl;

            Console.WriteLine("Introduceti un numar n pentru a afisa oglinditul lui.");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            if(n == 0)
            {
                Console.WriteLine($"Oglinditul numarului {n} este 0.");
            }

            ogl = 0;

            while(n > 0)
            {
                ogl = ogl * 10 + n % 10;
                n = n / 10;
                
            }
            Console.WriteLine($"Oglinditul numarului este {ogl}.");
        }
    }
}
