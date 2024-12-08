using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada\n");

            Console.WriteLine("Digite um número");
            int x = Convert.ToInt32(Console.ReadLine());
            int multiplicando = 1;
            while (multiplicando <= 10)
            {
                Console.WriteLine(x + " x " + multiplicando + " = " + (x * multiplicando));
                multiplicando++;
            }
        }
    }
}
