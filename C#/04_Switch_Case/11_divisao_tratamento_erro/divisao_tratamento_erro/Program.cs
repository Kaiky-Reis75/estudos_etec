using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisao_tratamento_erro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esse programa realiza a divisão de dois números inteiros, tratando a exceção de divisão por zero.
            try
            {
                Console.WriteLine("Digite o dividendo:");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o divisor:");
                int n2 = int.Parse(Console.ReadLine());
                int res = n1 / n2;
                Console.WriteLine("O resultado da divisão é: " + res);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: divisão por zero não é permitida!");
            }
            Console.ReadKey();
        }
    }
}
