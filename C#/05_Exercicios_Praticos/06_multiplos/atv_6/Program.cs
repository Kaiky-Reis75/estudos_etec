using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Esse programa tem a função de mostrar os números múltiplos de 5 e de 9, entre 1000 e 10000,
            e também mostrar os números múltiplos de 5 mas não de 9,
            e os números múltiplos de 9 mas não de 5.*/
            for (int i = 1000; i <= 10000; i++)
            {
                if(i % 5 == 0 && i % 9 == 0)
                {
                    Console.WriteLine("\n" + i + " é multiplo de 5 e de 9.");
                }
                else if (i % 5 == 0 && i % 9 != 0)
                {
                    Console.WriteLine("\n" + i + " é multiplo de 5 mas não é de 9.");
                }
                else if (i % 5 != 0 && i % 9 == 0)
                {
                    Console.WriteLine("\n" + i + " é multiplo de 9 mas não é multiplo de 5.");
                }
            }
            Console.ReadKey();
        }
    }
}
