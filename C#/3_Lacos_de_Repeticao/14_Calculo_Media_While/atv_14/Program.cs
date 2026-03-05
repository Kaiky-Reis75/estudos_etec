using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esse programa recebe as notas do usuário e calcula a média, o programa para de receber as notas quando o usuário digitar um número negativo.
            double nota = 0, n = 0, cont = 0;
            do
            {
                Console.WriteLine("\nDigite a sua nota:");
                n = double.Parse(Console.ReadLine());
                nota = nota + n;
                cont++;
            }
            while (n > 0);
            double res = nota / (cont - 1);
            Console.WriteLine("A sua média é de " + res);
            Console.ReadKey();
        }
    }
}
