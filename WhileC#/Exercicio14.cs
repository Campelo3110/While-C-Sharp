using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio14
    {
        public static void Main(string[] args)
        {
            int numero;
            int somaPares = 0;

            do
            {
                Console.WriteLine("Digite um número inteiro (digite 0 para parar):");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero != 0 && numero % 2 == 0)
                {
                    somaPares += numero;
                }

            } while (numero != 0);

            Console.WriteLine($"A soma dos números pares digitados é: {somaPares}");
        }
    }

}

