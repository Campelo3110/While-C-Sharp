using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace WhileC_
{
    internal class Exercicio6
    {
        //Implemente uma calculadora que permita ao usuário escolher uma operação(+, -, *, /). 
        //O programa deve continuar pedindo uma nova operação até que o usuário digite "sair".  

        public static void Main(string[] args)
        {
            Console.WriteLine("Calculadora\n");

            double resultado = 0;

            string decisao = "";

            while (decisao != "sair")
            {
                Console.WriteLine("Digite o primeiro número");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o operador");
                string operador = Convert.ToString(Console.ReadLine());
                switch (operador)
                {
                    case "+":
                        resultado = x + y;
                        break;
                    case "-":
                        resultado = x - y;
                        break;
                    case "*":
                        resultado = x * y;
                        break;
                    case "/":
                        resultado = x / y;
                        break;
                    default:
                        Console.WriteLine("Operador digitado não corresponde com os disponiveis");
                        break;
                }

                Console.WriteLine("O resultado da conta é " + resultado + "\n");

                Console.WriteLine("Deseja continuar?");
                decisao = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
            }
        }
    }
}
