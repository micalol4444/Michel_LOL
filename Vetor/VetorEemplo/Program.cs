using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorEemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetNomes = new string[3];

            //vetnomes[0] = "juquinha";
            //vetnomes[1] = "maria";
            //vetnomes[2] = "teobaldo";
            Console.WriteLine("insira o primeiro nome: ");
            vetNomes[0] = Console.ReadLine();

            Console.WriteLine("insira o segundo nome nome: ");
            vetNomes[1] = Console.ReadLine();

            Console.WriteLine("insira o terceiro nome: ");
            vetNomes[2] = Console.ReadLine();

            Console.WriteLine("===Apresentando os valores do vetor===");

            Console.WriteLine(vetNomes[0]);
            Console.WriteLine(vetNomes[1]);
            Console.WriteLine(vetNomes[2]);

        } 
    }
}
