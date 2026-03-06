using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que recebe um número do usuário e calcula o fatorial desse número, exibindo o resultado, utilizando While.
            Console.WriteLine("Informe qual número você deseja fatorar:");
            int n = int.Parse(Console.ReadLine());
            int fat = n;
            int i = n - 1;
            while (i >= 1)
            {
                fat = fat*i;
                Console.WriteLine(n + "! " + i + " = " + fat);
                i--;
            }
            Console.WriteLine("\nO resultado da fatoração é " + fat);
            Console.ReadKey();
        }
    }
}
