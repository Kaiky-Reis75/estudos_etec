using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_menor
{
    internal class Program
    {
        // Analisa dois números e informa qual deles é o maior
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine(num1 + " é maior que " + num2);
            }
            else
            {
                Console.WriteLine(num2 + " é maior que " + num1);
            }

            Console.ReadKey();
        }
    }
}
