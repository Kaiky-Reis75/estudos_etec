using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa de contagem regressiva, onde o usuário insere um número e o programa conta regressivamente até zero.
            Console.WriteLine("Insira de onde você deseja iniciar a contagem regressiva:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\n");
            for (int i = n; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
