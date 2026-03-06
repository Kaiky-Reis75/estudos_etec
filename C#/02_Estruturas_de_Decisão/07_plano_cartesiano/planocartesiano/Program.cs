using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planocartesiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que recebe as coordenadas X e Y de um ponto e informa em qual quadrante do plano cartesiano ele se encontra.1
            Console.WriteLine("Informe a coordenanda X:");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a coordenanda Y:");
            int Y = int.Parse(Console.ReadLine());

            if(X > 0 && Y > 0)
            {
                Console.WriteLine("\nA coordenada (" + X + "," + Y + ") está no 1º quadrante");
            }
            else if(X < 0 && Y > 0)
            {
                Console.WriteLine("\nA coordenada (" + X + "," + Y + ") está no 2º quadrante");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("\nA coordenada (" + X + "," + Y + ") está no 3º quadrante");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("\nA coordenada (" + X + "," + Y + ") está no 4º quadrante");
            }
            else
            {
                Console.WriteLine("\nA coordenada está na Origem");
            }
            Console.ReadKey();
        }
    }
}
