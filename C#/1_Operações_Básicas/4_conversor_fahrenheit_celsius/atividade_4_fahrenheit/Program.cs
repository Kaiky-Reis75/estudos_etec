using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_4_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversor de Fahrenheit para Celsius
            Console.WriteLine("Digite a temperatura em Fahrenheit:");
            float F = float.Parse(Console.ReadLine());
            // Formula de conversão
            float C = 5 * (F - 32) / 9;

            Console.WriteLine("\n\nA temperatura Fahrenheit é " + F + "\n\nConvertido para Celsius é " + C);

            Console.ReadKey();
        }
    }
}
