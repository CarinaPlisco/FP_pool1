using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
            //Se cere sa se inverseze valorile lor. 

            int a, b, x;

            Console.WriteLine("Introduceti valorile a si b pe care doriti sa le inversati. ");

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("a = {0}, b = {1}", a, b);

            x = a;
            a = b;
            b = x;

            Console.WriteLine($"Valorile inversate sunt a = {a} si b = {b}");
        }
    }
}
