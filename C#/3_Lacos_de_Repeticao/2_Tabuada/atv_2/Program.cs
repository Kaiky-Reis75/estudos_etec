using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuadasimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esse programa receba um número inteiro e mostre a tabuada desse número, de 0 a 10.
            Console.WriteLine("Digite a tabuada que você deseja:\n");
            int n1 = int.Parse(Console.ReadLine());

            for (int n2 = 0; n2 <= 10; n2++)
            {
                int res = n1 * n2;
                Console.WriteLine(n1 + " x " + n2 + " = " + res);
            }
            Console.ReadKey();
        }
    }
}
