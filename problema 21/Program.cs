using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
            int x, nr;
            Random rnd = new Random(); //initializ generator de nr

            x = rnd.Next(1, 1024); //genereaza nr intre 1 si 1024

            do
            {
                Console.WriteLine(" Dati un numar intre 1 si 1024");
                nr = int.Parse(Console.ReadLine());

                Console.WriteLine(" Numarul este mai mare sau egal decat x?");

                if (nr > x)
                    Console.WriteLine("Da");
                if (nr < x)
                    Console.WriteLine("Nu");
            }
            while (nr != x);

            Console.WriteLine($" Numarul selectat de calculator este {x}. ");
        }
    }
}
