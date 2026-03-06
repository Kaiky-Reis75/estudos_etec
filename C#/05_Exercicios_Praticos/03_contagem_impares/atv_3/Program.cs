using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_3
{
    class Program
    {
        static void Main(string[] args)
        { // Este programa lê 10 números e conta quantos deles são ímpares. O resultado é exibido no final.
            int imp = 0;
            for (int i = 1; i <= 10; i++)
            {   
                Console.WriteLine("\nDigite o seu " + i + "º número:");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 1)
                {
                    imp = imp + 1;
                }
            }
            Console.WriteLine("\nÍmpares = " + imp);
            Console.ReadKey();
        }
    }
}
