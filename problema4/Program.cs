using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca un an y este an bisect. 

            Console.WriteLine("Este anul introdus unul bisect?");

            int y;
            Console.WriteLine("Introduceti anul pentru verificare: ");
            y = int.Parse(Console.ReadLine());

            if(y % 100 != 0 && y % 4 == 0 || y % 400 == 0)
            {
                Console.WriteLine("Anul {0} este bisect.", y);
            }
            else
            { 
                Console.WriteLine("Anul {0} nu este bisect.", y);
            } 
        }
    }
}
