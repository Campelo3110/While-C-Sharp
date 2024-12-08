using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculadora\n");

            Console.WriteLine("Digite um numero:");
            int soma = Convert.ToInt32(Console.ReadLine());
            int digitado = 0;
            do
            {
                soma += digitado;
                Console.WriteLine("Digite um outro numero:");
                digitado = Convert.ToInt32(Console.ReadLine());

            } while(digitado != 0);

            Console.WriteLine("A soma total dos números foi: " + soma);
        }
    }
}
