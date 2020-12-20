using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti cati ani bisecti sunt intre anii y1 si y2.

            Console.WriteLine("Cati ani bisecti sunt intre anii y1 si y2?");

            int y1, y2, i, contor;

            Console.WriteLine("Introduceti anii pentru verificare. ");

            Console.Write("y1 = ");
            y1 = int.Parse(Console.ReadLine());

            Console.Write("y2 = ");
            y2 = int.Parse(Console.ReadLine());

            contor = 0;
            for (i = y1; i <= y2; i++)
            {
                if (i % 100 != 0 && i % 4 == 0 || i % 400 == 0)
                {
                    contor++;
                }
            }
            if (contor == 0)
            {
                Console.WriteLine("Nu exista ani bisecti in intervalul {0} - {1}.", y1, y2);
            }
            else 
            {
                Console.WriteLine($"Exista {contor} ani bisecti in intervalul {y1} - {y2}.");
            }
        }
    }
}
