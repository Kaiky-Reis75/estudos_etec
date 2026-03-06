using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que recebe um número do usuário e exibe os múltiplos de 3 até esse número.
            int mult = 0;
            Console.WriteLine("Digite até qual número você deseja ver os múltiplos de 3:");
            int n = int.Parse(Console.ReadLine());
            while (mult < n)
            {
                mult = mult + 3;
                Console.WriteLine(mult);
            }
            Console.ReadKey();
        }
    }
}
