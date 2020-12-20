using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti daca un numar n este palindrom.
            //un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 

            int n, ogl, aux;

            Console.WriteLine("Introduceti un numar pentru verificare.");

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            ogl = 0;
            aux = n;

            while(aux > 0)
            {
                ogl = ogl * 10 + aux % 10;
                aux = aux / 10;
            }

            if(n != ogl) //daca este diferit de oglindit
            {
                  Console.WriteLine($"Numarul {n} nu este palindrom.");
            }

            if(n == ogl) //daca este oglinditul
             {
                  Console.WriteLine($"Numarul {n} este palindrom.");
             }
        }
    }
}
