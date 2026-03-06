using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_de__moeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esse programa é um conversor de moedas que converte valores de Dólar, Euro e Libra para Real, utilizando as taxas de câmbio.
            Console.WriteLine("Digite o valor que deseja converter:");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Selecione a moeda a ser convertida:\n\n" +
                "1 - Dólar\n" +
                "2 - Euro\n" +
                "3 - Libra\n");
            int opc = int.Parse(Console.ReadLine());
            double res = 0;

            switch (opc) {
                case 1:
                    res = valor * 5.76f;
                    Console.WriteLine("O valor do câmbio de Dólar para Real é R$" + res);
                    break;
                case 2:
                    res = valor * 6.54f;
                    Console.WriteLine("O valor do câmbio de Euro para Real é R$" + res);
                    break;
                case 3:
                    res = valor * 7.43f;
                    Console.WriteLine("O valor do câmbio de Libra para Real é R$" + res);
                    break;
            }
            Console.ReadKey();
        }
    }
}
