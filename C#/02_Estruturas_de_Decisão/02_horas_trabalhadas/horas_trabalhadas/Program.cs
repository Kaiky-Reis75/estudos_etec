using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horas_trabalhadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Recebe a quantidade de horas trabalhadas e calcula o salário total, considerando que o valor da hora é R$20,00 e que as horas excedentes a 150 horas são pagas com um adicional de 50% (R$30,00 por hora excedente).
            Console.WriteLine("Digite a sua quantidade de horas trabalhadas:");
            int hrs = int.Parse(Console.ReadLine());

            if (hrs > 150){
                int exc = 30 * (hrs - 150);
                int salario = 20 * 150;
                int total = salario + exc;
                Console.WriteLine("\nO salário total será de R$" + total + "\n\nDesse valor o excedente é de R$" + exc);
            }
            else{
                int total = hrs * 20;
                Console.WriteLine("\nO salário total será de R$" + total);
               }
            Console.ReadKey();            
        }
    }
}