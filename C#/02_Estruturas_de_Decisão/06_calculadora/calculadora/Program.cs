using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora simples utilizando estruturas de decisão para decidir a operação desejada.
            Console.WriteLine("Digite o primeiro valor para o cálculo");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor para o cálculo");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nEscolha a operação desejada digitando o número correspondente a ela:\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n");
            int operacao = int.Parse(Console.ReadLine());

            if (operacao == 1)
            {
                float resultado = num1 + num2;
                Console.WriteLine("\n\nO Resultado da adição de " + num1 + "+" + num2 + "=" + resultado);
            }
            else if(operacao == 2)
            {
                float resultado = num1 - num2;
                Console.WriteLine("\n\nO Resultado da subtração de " + num1 + "-" + num2 + "=" + resultado);
            }
            else if (operacao == 3)
            {
                float resultado = num1 * num2;
                Console.WriteLine("\n\nO Resultado da multiplicação de " + num1 + "*" + num2 + "=" + resultado);
            }
            else if (operacao == 4)
            {
                float resultado = num1 / num2;
                Console.WriteLine("\n\nO Resultado da divisão de " + num1 + "/" + num2 + "=" + resultado);
            }
            else
            {
                Console.WriteLine("Nenhuma operação válida foi escolhida, tente novamente!");
            }
            Console.ReadKey();
        }
    }
}
