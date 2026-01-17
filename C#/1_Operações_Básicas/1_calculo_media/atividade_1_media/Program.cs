using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_1_media
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular a média de 5 números inteiros fornecidos pelo usuário
            Console.WriteLine("\n\n Digite o primeiro número inteiro:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\n Digite o segundo número inteiro:");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\n Digite o terceiro número inteiro:");
            float n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\n Digite o quarto número inteiro:");
            float n4 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\n Digite o quinto número inteiro:");
            float n5 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + n3 + n4 + n5) / 5;

            Console.WriteLine("\nA média dos numeros inseridos é " + media);

            Console.ReadKey();
        }
    }
}
