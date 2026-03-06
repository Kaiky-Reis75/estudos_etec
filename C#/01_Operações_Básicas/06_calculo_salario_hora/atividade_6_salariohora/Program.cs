using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_6_salariohora
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calcular o salário mensal baseado no valor da hora trabalhada e horas trabalhadas no mês
            Console.WriteLine("Insira o quanto você recebe por hora:");
            float valor = float.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira suas horas trabalhadas esse mês:");
            float hrs = float.Parse(Console.ReadLine());

            float salario = valor * hrs;

            Console.WriteLine("\n\nO seu salário desse mês é de R$" + salario);

            Console.ReadKey();
        }
    }
}
