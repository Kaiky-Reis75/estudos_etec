using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_2_raio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular o comprimento e área de um circulo
            Console.WriteLine("Digite o raio do circulo:");
            float r = float.Parse(Console.ReadLine());
            float c = 2 * 3.14f * r;
            float a = 3.14f * (r * r);

            Console.WriteLine("\n\nO Comprimento da circunferência é " + c + "\n\nE a Área da circunferência é " + a);

            Console.ReadKey();
        }
    }
}
