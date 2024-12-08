using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Contagem regressiva \n");
            
            Console.WriteLine("Deseja iniciar? (1 para sim, 2 para não)");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
              int contador = 10;
              while (contador >= 1)
              {
                  Console.WriteLine("Contagem: " + contador);
                  contador--;
              }
            }else if (escolha == 2)
            {
                Console.WriteLine("Fechando");
            }
            else
            {
                Console.WriteLine("Não corresponde a nenhuma das opções disponiveis");
            }
        }
    }
}
