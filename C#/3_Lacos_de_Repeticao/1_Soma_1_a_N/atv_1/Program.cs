using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que lê um número e imprime a soma de 1 até esse número, utilizando um laço de repetição.
            int soma = 0;
            Console.WriteLine("Digite até que número você deseja que apareça na tela:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                soma = soma + i;
                Console.Write(i);
                if (i < n)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine(" = " + soma);
            Console.ReadKey();
        }
    }
}
