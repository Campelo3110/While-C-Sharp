using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio12
    {

        public static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Por favor, digite um número entre 1 e 100:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 1 || numero > 100)
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }

            } while (numero < 1 || numero > 100);

            Console.WriteLine($"Você digitou um número válido: {numero}");
        }
    }

}
