using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Esse programa sorteia um número de 0 à 100 e o usuário tem que adivinhar qual é o número sorteado
            O programa deve informar se o valor digitado é maior ou menor que o valor sorteado, até que o usuário acerte o número.*/
            int adv = 101;
            Random n = new Random();
            int i = n.Next(0, 100);
            while (adv != i)
            {
                Console.WriteLine("\nAdvinhe o número de 0 à 100:");
                adv = int.Parse(Console.ReadLine());
                if (i == adv)
                {
                    Console.WriteLine("\nPARABÉNS! Você acertou.");
                }
                else if (i > adv)
                {
                    Console.WriteLine("\nO valor digitado é menor que o valor sorteado!");
                }
                else
                {
                    Console.WriteLine("\nO valor digitado é maior que o valor sorteado!");
                }
            }
            Console.ReadKey();
        }
    }
}
