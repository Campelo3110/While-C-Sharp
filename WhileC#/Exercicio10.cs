using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para verificar se é primo:");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool ehPrimo = true;
            int divisor = 2;

            while (divisor <= Math.Sqrt(numero))
            {
                if (numero % divisor == 0)
                {
                    ehPrimo = false;
                    break;
                }
                divisor++;
            }

            if (ehPrimo && numero > 1)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }
    }
}

