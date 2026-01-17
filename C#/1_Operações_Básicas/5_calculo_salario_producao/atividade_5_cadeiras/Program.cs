using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_5_cadeiras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de cadeiras que você fabricou:");
            int qtd = int.Parse(Console.ReadLine());

            // Salário fixo de R$2000,00 + R$80,00 por cadeira produzida
            int total = 2000 + (qtd * 80);

            Console.WriteLine("\nO seu salário desse mês é de R$"+total);

            Console.ReadKey();

        }
    }
}
