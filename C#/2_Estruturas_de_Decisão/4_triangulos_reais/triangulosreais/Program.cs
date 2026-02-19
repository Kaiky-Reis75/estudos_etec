using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulosreais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que recebe o valor de cada lado de um triângulo e informa se ele é equilátero, isósceles ou escaleno.
            Console.WriteLine("Informe o valor do lado A do triângulo");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do lado B do triângulo");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do lado C do triângulo");
            float C = float.Parse(Console.ReadLine());

            if ((A < (B + C)) && (B < (C + A)) && (C < (A + B)))
            {
                if ((A == B) && (B == C))
                {
                    Console.WriteLine("É um triângulo equilátero");
                }
                else if ((A == B) || (A == C) || (B == C))
                {
                    Console.WriteLine("É um triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("É um triângulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Esses dados não correspondem a um triângulo verdadeiro");
            }
            Console.ReadKey();
        }
    }
}