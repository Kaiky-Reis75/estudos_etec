using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esse programa recebe uma quantidade de notas, depois recebe o valor de cada nota, calcula a média e exibe o resultado.
            double tot = 0;
            Console.WriteLine("Informe a quantidade de notas que serão inseridas:");
            double q = int.Parse(Console.ReadLine());
            for (int i = 1; i <= q; i++)
            {   
                Console.WriteLine("\nDigite o valor da " + i + "º nota:");
                double nota = int.Parse(Console.ReadLine());
                tot = nota + tot;
            }
            double media = tot / q;
            Console.WriteLine("\nA média das " + q + " notas inseridas é " + media);
            Console.ReadKey();
        }
    }
}
