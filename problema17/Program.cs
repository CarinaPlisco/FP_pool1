using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. 
            //Folositi algoritmul lui Euclid. 

            int a, b, a2, b2, mc;
            
            Console.WriteLine("Introduceti doua numere a si b: ");

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            a2 = a;
            b2 = b;

            while (a2 != b2) //CMMDC prin Euclid
            {
                if (a2 > b2)  a2 = a2 - b2;
                else b2 = b2 - a2;
            } //a2 = b2

            Console.WriteLine($" Cel mai mare divizor comun este {a2}. ");

            mc = (a * b) / a2; //CMMMC prin Euclid

            Console.WriteLine($" Cel mai mic multiplu comun este {mc}. ");
        }
    }
}
