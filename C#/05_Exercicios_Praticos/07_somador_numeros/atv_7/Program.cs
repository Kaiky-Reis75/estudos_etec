using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esse programa Lê numeros inteiros do usuário até que o número 0 seja digitado. O programa deve contar quantos números foram digitados (excluindo o 0) e exibir essa quantidade ao final.
            int n = 0, q = 0;
            do
            {
                Console.WriteLine("\nDigite um número:");
                n = int.Parse(Console.ReadLine());
                q++;
                if(n == 0)
                {
                    q--;
                }
            } while (n != 0);
            Console.WriteLine("O programa foi executado " + q + " vezes.");
            Console.ReadKey();
        }
    }
}
