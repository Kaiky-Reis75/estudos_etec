using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora de IMC onde o usuário irá informar o peso e a altura, e o programa irá calcular o IMC e mostrar a classificação do peso de acordo com a tabela de IMC.
            Console.WriteLine("Informe o seu peso em kg:");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a sua altura em centímetros");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc > 40)
            {
                Console.WriteLine("Você está com Obesidade grau 3");
            }
            else if ((imc > 35) && (imc < 39.9))
            {
                Console.WriteLine("Você está com Obesidade grau 2");
            }
            else if ((imc > 30) && (imc < 34.9))
            {
                Console.WriteLine("Você está com Obesidade grau 1");
            }
            else if ((imc > 25) && (imc < 29.9))
            {
                Console.WriteLine("Você está com Sobrepeso");
            }
            else if ((imc > 18.5) && (imc < 24.9))
            {
                Console.WriteLine("Você está com Peso Normal");
            }
            else if (imc < 18.5)
            {
                Console.WriteLine("Você está Abaixo do Peso");
            }
                Console.ReadKey();
        }
    }
}
