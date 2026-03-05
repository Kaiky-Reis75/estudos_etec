using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calculo_imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa para calcular o IMC (Índice de Massa Corporal) e classificar o resultado em categorias de peso. Com tratamento de exceção para entradas inválidas.
            try
            {
                Console.WriteLine("Informe o seu peso em kg:");
                float peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe a sua altura em centímetros");
                float altura = float.Parse(Console.ReadLine());
                float imc = peso / (altura * altura);

                switch (imc)
                {
                    case float n when (imc > 40):
                        Console.WriteLine("Você está com Obesidade grau 3");
                        break;
                    case float n when ((imc > 35) && (imc < 39.9)):
                        Console.WriteLine("Você está com Obesidade grau 2");
                        break;
                    case float n when ((imc > 30) && (imc < 34.9)):
                        Console.WriteLine("Você está com Obesidade grau 1");
                        break;
                    case float n when ((imc > 25) && (imc < 29.9)):
                        Console.WriteLine("Você está com Sobrepeso");
                        break;
                    case float n when ((imc > 18.5) && (imc < 24.9)):
                        Console.WriteLine("Você está com Peso Normal");
                        break;
                    default:
                        Console.WriteLine("Você está Abaixo do Peso");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida!");
            }
            Console.ReadKey();
        }
    }
}
