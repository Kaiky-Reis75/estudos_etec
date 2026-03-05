using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamento_de_erro
{
    internal class Program
    {
        static void Main(string[] args)
        // Esse programa tem como objetivo mostrar o tratamento de erro utilizando a estrutura try catch, para evitar que o programa seja interrompido caso o usuário digite um valor inválido.
        {
            try {
                Console.WriteLine("Digite um número:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi: " + n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida, digite um número!");
            }
            Console.ReadKey();
        }
    }
}
