using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_de_veiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esse programa tem como objetivo mostrar o tipo de veículo escolhido pelo usuário, utilizando a estrutura de controle switch case.
            Console.WriteLine("Escolha o seu tipo de veículo:\n" +
                "1 - Carro\n" +
                "2 - Moto\n" +
                "3 - Bicicleta\n" +
                "4 - Caminhão");
            int tipo = int.Parse(Console.ReadLine());
            switch (tipo) {
                case 1:
                    Console.WriteLine("\n\nO seu tipo de veículo é um carro!");
                    break;
                case 2:
                    Console.WriteLine("\n\nO seu tipo de veículo é uma moto!");
                    break;
                case 3:
                    Console.WriteLine("\n\nO seu tipo de veículo é uma bicicleta!");
                    break;
                case 4:
                    Console.WriteLine("\n\nO seu tipo de veículo é um caminhão!");
                    break;
                default:
                    Console.WriteLine("\n\nOpção Inválida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
