using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero1;
            double numero2;
            double resolucao = 0;
            String operacao;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a operação: ");
            operacao = Console.ReadLine();

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            switch (operacao)
            {

                case "+":

                    resolucao = numero1 + numero2;
                    Console.WriteLine("A soma dos números é: " + resolucao);
                    break;

                case "-":

                    resolucao = numero1 - numero2;
                    Console.WriteLine("A subtração dos números é: " + resolucao);
                    break;

                case "*":
                    resolucao = numero1 * numero2;
                    Console.Write("A multiplicação dos números é: " + resolucao);
                    break;

                case "/":
                    resolucao = numero1 / numero2;
                    Console.WriteLine("A divisão dos múmeros é: " + resolucao);
                    break;

            }

            Console.ReadKey();

        }
    }
}
