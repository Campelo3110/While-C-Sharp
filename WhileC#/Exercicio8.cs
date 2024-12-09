using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio8
    {
        //Implemente um programa que pede ao usuário para adivinhar um número secreto(previamente definido pelo programa). 
        //O programa deve continuar pedindo até que o número correto seja adivinhado.

        public static void Main(string[] args)
        {
            int numeroSecreto = 5;
            int tentativa = 0;
            Console.WriteLine("Adivinhe o número secreto!");
            do
            {
                Console.WriteLine("Digite seu palpite: ");
                tentativa = Convert.ToInt32(Console.ReadLine());
                if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo! Tente Novamente.");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("Muito alto! Tente novamente. ");
                }
                else
                {
                    Console.WriteLine("Parabens! Você acertou o número secreto.");
                }

            } while (tentativa != numeroSecreto);
        }
    }
}
