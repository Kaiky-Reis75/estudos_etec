using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_erro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esse programa é uma calculadora simples que realiza as operações de soma, subtração, multiplicação e divisão. Ele também trata a exceção de divisão por zero.
            try
            {
                Console.WriteLine("Informe o primeiro número:");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\nInforme o segundo número:");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\nInforme a operação matemática desejada, digitando o número correspondente:\n\n" +
                    "1 - Soma\n" +
                    "2 - Subtração\n" +
                    "3 - Multiplicação\n" +
                    "4 - Divisão");
                int opc = int.Parse(Console.ReadLine());
                int result = 0;
                switch (opc)
                {
                    case 1:
                        result = n1 + n2;
                        break;
                    case 2:
                        result = n1 - n2;
                        break;
                    case 3:
                        result = n1 * n2;
                        break;
                    case 4:
                        result = n1 / n2;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.WriteLine("\nO resultado da operação é: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: divisão por zero não é permitida!");
            }
            Console.ReadKey();
        }
    }
}
