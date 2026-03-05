using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selecao_operacao_matematica
{
    internal class Program
    {
        static void Main(string[] args)
        // Programa que recebe dois números e uma operação matemática desejada, e retorna o resultado da operação entre os dois números.
        {
            Console.WriteLine("Informe o primeiro número:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\nInforme o segundo número:");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\nInforme a operação matemática desejada, digitando o número correspondente:\n\n" +
                "1 - Soma\n" +
                "2 - Subtração\n" +
                "3 - Multiplicação\n" +
                "4 - Divisão");
            int opc = int.Parse(Console.ReadLine());
            float result = 0;
            switch (opc)
            {
                case int n when (n == 1):
                    result = n1 + n2;
                    break;
                case int n when (n == 2):
                    result = n1 - n2;
                    break;
                case int n when (n == 3):
                    result = n1 * n2;
                    break;
                case int n when (n == 4):
                    result = n1 / n2;
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.WriteLine("\nO resultado da operação é: " + result);
            Console.ReadKey();
        }
    }
}
