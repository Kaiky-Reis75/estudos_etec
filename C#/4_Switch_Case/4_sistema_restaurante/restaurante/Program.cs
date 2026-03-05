using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que simula um cardápio de restaurante, onde o usuário escolhe um prato e a quantidade, e o programa calcula o valor total da compra.
            Console.WriteLine("Escolha o prato desejado:\n" +
                "1 - Hambúrguer\n" +
                "2 - Pizza\n" +
                "3 - Salada\n");
            int prato = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade:\n");
            int quant = int.Parse(Console.ReadLine());
            int total = 0;

            switch (prato)
            {
                case 1:
                    total = quant * 15;
                    break;
                case 2:
                    total = quant * 30;
                    break;
                case 3:
                    total = quant * 12;
                    break;
            }
            Console.WriteLine("O valor total do seu é R$" + total);
            Console.ReadKey();
        }
    }
}
