using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int contador = 0;

            while (numero > 0)
            {
                numero /= 10;
                contador++;
            }

            Console.WriteLine($"O número digitado possui {contador} dígitos.");
        }
    }

}

