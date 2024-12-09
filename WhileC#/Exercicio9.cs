using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio9
    {
        public static void Main(string[] args)
        {
            string entrada;
            int contadorVogais;

            Console.WriteLine("Digite 'sair' para encerrar o programa.");
            do
            {
                Console.Write("Digite uma palavra ou frase: ");
                entrada = Console.ReadLine();

                if (entrada == "sair")
                    break;

                contadorVogais = 0;
                foreach (char c in entrada)
                {
                    if ("aeiouAEIOU".Contains(c))
                        contadorVogais++;
                }

                Console.WriteLine($"Número de vogais: {contadorVogais}");


            } while (true);
        }
    }
}
