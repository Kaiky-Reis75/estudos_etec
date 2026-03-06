using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculadora de Fatorial usando a estrutura de repetição for.
            Console.WriteLine("Digite o número que será fatorado:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int fat = n;


            for (int i = n - 1; i >= 1; i--)
            {
                fat = fat * i;
                Console.WriteLine(n + "! " + i + " = " + fat);
            }
            Console.WriteLine("\nO resultado da fatoração é " + fat);
            Console.ReadLine();
        }
    }
}
