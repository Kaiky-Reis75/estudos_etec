using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa para escolher a classe do personagem utilizando o comando switch case.
            Console.WriteLine("Escolha a classe do seu personagem:\n" +
                "1 - Guerreiro\n" +
                "2 - Mago\n" +
                "3 - Arqueiro\n" +
                "4 - Ninja\n");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("\nA classe escolhida foi Guerreiro!");
                    break;
                case 2:
                    Console.WriteLine("\nA classe escolhida foi Mago!");
                    break;
                case 3:
                    Console.WriteLine("\nA classe escolhida foi Arqueiro!");
                    break;
                case 4:
                    Console.WriteLine("\nA classe escolhida foi Ninja!");
                    break;
                default:
                    Console.WriteLine("\nOpção Inválida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
