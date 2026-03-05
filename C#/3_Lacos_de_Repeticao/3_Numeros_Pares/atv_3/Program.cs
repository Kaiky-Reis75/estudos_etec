using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que imprime os números pares de 1 até um número digitado pelo usuário.
            Console.WriteLine("Digite até qual número para você deseja ver:");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int n = 1; n <= max; n++)
            {
                int sobra = n % 2;
                if (sobra == 0)
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadKey();
        }
    }
}
