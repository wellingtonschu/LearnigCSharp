﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            String nomePessoa;
            String sobrenomePessoa;

            Console.WriteLine("Digite seu nome: ");
            nomePessoa = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            sobrenomePessoa = Console.ReadLine();

            Console.WriteLine("O nome escrito foi " + nomePessoa + " " + sobrenomePessoa);

            Console.ReadKey();

        }
    }
}
