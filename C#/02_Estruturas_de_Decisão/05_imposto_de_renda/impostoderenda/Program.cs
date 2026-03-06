using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impostoderenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esse programa recebe o salário por hora e as horas trabalhadas no mês, para calcular o imposto de renda.
            Console.WriteLine("Informe o seu salário por hora:");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe as suas horas trabalhadas esse mês:");
            float horas = float.Parse(Console.ReadLine());
            float total = salario * horas;

            if(total > 4664.68)
            {
                Console.WriteLine("O seu salário desse mês é de R$" + total + " , sendo assim, você pagará 27,5% de imposto de renda.");
            }
            else if((total > 3751.06)&&(total < 4664.68)){
                Console.WriteLine("O seu salário desse mês é de R$" + total + " , sendo assim, você pagará 22,5% de imposto de renda.");
            }
            else if ((total > 2826.66) && (total < 3751.06)){
                Console.WriteLine("O seu salário desse mês é de R$" + total + " , sendo assim, você pagará 15% de imposto de renda.");
            }
            else if ((total > 1903.99) && (total < 2826.65)){
                Console.WriteLine("O seu salário desse mês é de R$" + total + " , sendo assim, você pagará 7,5% de imposto de renda.");
            }
            else
            {
                Console.WriteLine("O seu salário desse mês é de R$" + total + " , sendo assim, você está isento de pagar o imposto de renda.");
            }
            Console.ReadKey();
        }
    }
}
