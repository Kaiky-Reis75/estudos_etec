using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que lê um número inteiro e mostra os números ímpares até o número digitado.
            int i = 1, imp = 0;
            Console.WriteLine("Digite até qual número para você deseja ver:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            while (i <= n)
            {
                i = i + 2;
                imp++ ;
            }
            Console.WriteLine("O total de números ímpares é " + imp);
            Console.ReadKey();
        }
    }
}
