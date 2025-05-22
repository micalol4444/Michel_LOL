using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu
            
            string[] vetjogos = new string[3];
            do
            {
                Console.Clear();

                Console.WriteLine(@"𝕔𝕒𝕕𝕒𝕤𝕥𝕣𝕠 𝕕𝕖 𝕛𝕠𝕘𝕠𝕤");
                Console.WriteLine("1 - cadastra");
                Console.WriteLine("2 - consultar");
                Console.WriteLine("3 - atualizar");
                Console.WriteLine("4 - excluir");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    //cadastrar nome no vetor
                    for (int i = 0; i < vetjogos.Length; i++)
                    {
                        Console.WriteLine($"informe o {i + 1}º nome do jogo");
                        vetjogos[i] = Console.ReadLine();

                       
                    }
                    Console.WriteLine("para continuar presione a tecla enter");
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    //CONSULTAR
                   
                        for (int i = 0; i < vetjogos.Length; i++)
                        {
                        Console.WriteLine($"posicao: {i + 1} | nome do jogo: {vetjogos[i]}");
                        }
                        Console.WriteLine("para continuar presione a tecla enter");
                        Console.ReadKey();
                    
                }
                else if (opcao == 3)
                {
                    //AUTALIZAR
                    Console.WriteLine("Incdice do nome a ser trocado");
                    int indice = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nome do novo indice");
                    string novoname = Console.ReadLine();

                    vetjogos[indice] = novoname;
                    
                }else if (opcao == 4)
                {
                    //EXCLUIR
                    Console.WriteLine("Indice a ser excluido");
                    int id = int.Parse(Console.ReadLine());

                    vetjogos[id] = "";
                }

            } while (true);
        }
    }
}
