using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio5
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Verificação de Paridade\n");

            double x = 1;
            while (x % 2 != 0)
            {
                Console.WriteLine("Digite um número");
                x = Convert.ToDouble(Console.ReadLine());
                if (x % 2 != 1)
                {
                    Console.WriteLine("Sucesso");
                }
            }
        }
    }
}
