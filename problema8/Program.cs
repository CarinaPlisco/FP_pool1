using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
            //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.

            int a, b;

            Console.WriteLine("Introduceti valorile a si b pe care doriti sa le inversati. ");

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Datele introduse sunt a = {0} si b = {1}", a, b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Valorile inversate sunt a = {a} si b = {b}");
        }
    }
}
