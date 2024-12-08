using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Contadora do 1 ao 10\n");
            int contadora = 1; 
            while (contadora <= 10)
            {
                Console.WriteLine("Contando : " + contadora);
                contadora++;
            }
        }
    }
}
