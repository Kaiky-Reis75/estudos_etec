using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que recebe a quantidade de números que o usuário deseja somar, e depois recebe cada número, um por um, e no final exibe a soma total.
            int cont = 1;
            int res = 0;
            Console.WriteLine("Informe a quantidade de número que você deseja somar:");
            int t = int.Parse(Console.ReadLine());
            int i = t;
            while (i > 0) {

                Console.WriteLine("Informe o " + cont + "º número que será somado:");
                int n = int.Parse(Console.ReadLine());
                res = n + res;
                cont++;
                i--;
            }
            Console.WriteLine("\nA soma dos " + t + " números é " + res);
            Console.ReadKey();
        }
    }
}
