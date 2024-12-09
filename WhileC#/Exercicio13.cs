using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            int numero;
            int contadorPares = 0;
            int contadorImpares = 0;

            do
            {
                Console.WriteLine("Digite um número inteiro (digite 0 para parar):");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero % 2 == 0)
                    {
                        contadorPares++;
                    }
                    else
                    {
                        contadorImpares++;
                    }
                }

            } while (numero != 0);

            Console.WriteLine($"Você digitou {contadorPares} números pares.");
            Console.WriteLine($"Você digitou {contadorImpares} números ímpares.");
        }
    }
}
