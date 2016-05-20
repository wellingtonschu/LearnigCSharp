using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero;
            double total = 0;
            string operacao = "+";

            while (operacao != "=")
            {

                Console.WriteLine("Informe o valor: ");
                numero = Convert.ToDouble(Console.ReadLine());

                switch (operacao)
                {

                    case "+":

                        total = total + numero;
                        break;

                    case "-":

                        total = total - numero; ;
                        break;

                    case "*":
                        total = total * numero; ;
                        break;

                    case "/":
                        total = total / numero;
                        break;

                }

                Console.WriteLine("Informe a operação: ");
                operacao = Console.ReadLine();
            }

            Console.WriteLine("O resultado é: " + total);
            Console.ReadKey();
        }
    }
}
