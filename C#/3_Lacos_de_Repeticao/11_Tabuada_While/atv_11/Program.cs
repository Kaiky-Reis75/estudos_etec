using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa para mostrar a tabuada de um número usando o laço de repetição while.
            int i = 0;
            Console.WriteLine("Digite o número que você deseja ver a tabuada:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\n");
            while (i <= 10)
            {
                int res = n * i;
                Console.WriteLine(n + " x " + i + " = " + res);
                i++;
            }
            Console.ReadKey();
        }
    }
}
