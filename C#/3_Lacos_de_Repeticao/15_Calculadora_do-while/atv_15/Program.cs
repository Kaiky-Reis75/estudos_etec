using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esse programa é uma calculadora onde o usuário pode escolher a operação matemática desejada, informar os números e obter o resultado. O programa deve continuar executando até que o usuário escolha a opção de sair.
            int opc = 0;
            float n1 = 0, n2 = 0;
            do
            {
                Console.WriteLine("\nInforme a operação matemática desejada, digitando o número correspondente:\n\n" +
                "1 - Soma\n" +
                "2 - Subtração\n" +
                "3 - Multiplicação\n" +
                "4 - Divisão\n" +
                "5 - Sair");
                opc = int.Parse(Console.ReadLine());
                float result = 0;
                switch (opc)
                {
                    case int n when (n == 1):
                        Console.WriteLine("\n\nInforme o primeiro número:");
                        n1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\n\nInforme o segundo número:");
                        n2 = float.Parse(Console.ReadLine());
                        result = n1 + n2;
                        Console.WriteLine("\nO resultado da operação é: " + result);
                        break;
                    case int n when (n == 2):
                        Console.WriteLine("\n\nInforme o primeiro número:");
                        n1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\n\nInforme o segundo número:");
                        n2 = float.Parse(Console.ReadLine());
                        result = n1 - n2;
                        Console.WriteLine("\nO resultado da operação é: " + result);
                        break;
                    case int n when (n == 3):
                        Console.WriteLine("\n\nInforme o primeiro número:");
                        n1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\n\nInforme o segundo número:");
                        n2 = float.Parse(Console.ReadLine());
                        result = n1 * n2;
                        Console.WriteLine("\nO resultado da operação é: " + result);
                        break;
                    case int n when (n == 4):
                        Console.WriteLine("\n\nInforme o primeiro número:");
                        n1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\n\nInforme o segundo número:");
                        n2 = float.Parse(Console.ReadLine());
                        result = n1 / n2;
                        Console.WriteLine("\nO resultado da operação é: " + result);
                        break;
                    case int n when (n == 5):
                        opc = 5;
                        Console.WriteLine("\nVocê saiu do programa!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
            while (opc != 5);
            Console.ReadKey();
        }
    }
}
