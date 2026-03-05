using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esse programa lê um número inteiro e informa se ele é par ou ímpar. O programa continua a ler números até que o usuário digite 0.
            int n = 0;
            do
            {
                Console.WriteLine("\nDigite um número para saber se ele é ímpar ou par:");
                n = int.Parse(Console.ReadLine());
                int resto = n % 2;
                if (resto == 0)
                {
                    Console.WriteLine("\nEsse número é par!");
                }
                else
                {
                    Console.WriteLine("\nEsse número é ímpar!");
                }
            } while (n > 0 || n < 0);
            Console.ReadKey();
        }
    }
}
