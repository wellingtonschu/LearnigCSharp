using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            nome = new string[7];

            nome[0] = "Wellington";
            nome[1] = "Schütz";
            nome[2] = "Larissa";
            nome[3] = "Schütz";
            nome[4] = "Tony";
            nome[5] = "Schütz";
            nome[6] = "Junior";

            for(int i = 0; i < 7; i++)
            {
                Console.Write(nome[i]);
                Console.Write(" ");
            }

            Console.ReadKey();
        }
    }
}