using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esse programa lê 10 números e conta quantos deles são pares. O resultado é exibido no final.
            int par = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nDigite o seu " + i + "º número:");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    par = par + 1;
                }
            }
            Console.WriteLine("\nPares = " + par);
            Console.ReadKey();
        }
    }
}


