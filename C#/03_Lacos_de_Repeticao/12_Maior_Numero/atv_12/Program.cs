using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Recebe dois números e informa qual é o maior. O programa deve ser repetido até o usuário digitar 'sair'.
            int n1 = 0, n2 = 0;
            while (n1 >= 0 && n2 >= 0)
            {
                Console.WriteLine("\nInforme o primeiro número a ser comparado:");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nInforme o segundo número a ser comparado:");
                n2 = int.Parse(Console.ReadLine());
                if (n1 > n2)
                {
                    Console.WriteLine("\nO número " + n1 + " é maior que o número " + n2);
                }
                else
                {
                    Console.WriteLine("\nO número " + n2 + " é maior que o número " + n1);
                }
                Console.WriteLine("\n...................\n\n Aperte 'Enter' para continuar ou, digite 'sair' para encerrar");
                string entrada = Console.ReadLine();
                if (entrada == "sair")
                {
                    break;
                }
            }
        }
    }
}
