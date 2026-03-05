using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_preco_desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esse programa calcula o preço de um produto com desconto, caso a quantidade seja maior que 10 unidades.
            Console.WriteLine("Selecione uma das opções:\n" +
                "1 - Caneta R$2,00\n" +
                "2 - Caderno R$15,00\n" +
                "3 - Mochila R$120,00\n");
            int opc = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme a quantidade:\n");
            int qtd = int.Parse(Console.ReadLine());
            float result = 0;

            switch (opc)
            {
                case 1:
                    result = 2 * qtd;
                    break;
                case 2:
                    result = 15 * qtd;
                    break;
                case 3:
                    result = 120 * qtd;
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    result = 0;
                    break;
            }
            if (qtd > 10)
            {
                result = result * 0.95f;
            }
            Console.WriteLine("Resultado: R$" + result);
            Console.ReadKey();
        }
    }
}
