using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_3_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular o salário com desconto de 14% do INSS
            Console.WriteLine("Digite o valor do seu salário:");
            float salario = float.Parse(Console.ReadLine());
            float inss = salario * 0.14f;
            float desc = salario - inss;

            Console.WriteLine("\n\nO seu salário com o desconto do INSS é " + desc);

            Console.ReadKey();
        }
    }
}
