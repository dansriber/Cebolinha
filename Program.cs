using System;

namespace Pasta_Visual
{
    class Program
    {
        static void Main(string[] args)
        {
           string frase;

            //<---Inicio(Digite)--->//
            Console.Write("Digite Qualquer Coisa: ");
            frase = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine($"{frase.Replace("r", "l").Replace("R", "L")}");
            //<---Fim(Digite)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->//
        }
    }
} 
