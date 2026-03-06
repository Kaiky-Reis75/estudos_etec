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
            // Este programa lê uma quantidade de números definida pelo usuário e exibe a soma dos números pares e a soma dos números ímpares. O resultado é exibido no final.
            int totalpar = 0, totalimp = 0;
            Console.WriteLine("Digite quantos números você deseja inserir:");
            int q = int.Parse(Console.ReadLine());
            for (int i = 1; i <= q; i++)
            {
                Console.WriteLine("\nDigite o seu " + i + "º número:");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    totalpar = totalpar + n;
                }
                else
                {
                    totalimp = totalimp + n;
                }
            }
            Console.WriteLine("\nSoma dos pares = " + totalpar + "\n" +
                "Soma dos ímpares = " + totalimp);
            Console.ReadKey();
        }
    }
}
