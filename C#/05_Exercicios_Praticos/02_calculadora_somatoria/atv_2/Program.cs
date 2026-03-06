using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este programa lê um número inteiro e exibe a soma de todos os números inteiros de 1 até o número digitado. O resultado é exibido no final.
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
