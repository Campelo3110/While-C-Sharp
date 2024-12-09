using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = numero;
            int potencia = 1;

            while (resultado <= 1000)
            {
                Console.WriteLine($"{numero} x 2^{potencia - 1} = {resultado}");
                resultado = numero * (int)Math.Pow(2, potencia);
                potencia++;
            }
        }
    }
}

