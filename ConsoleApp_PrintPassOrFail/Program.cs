using System;

namespace ConsoleApp_PrintPassOrFail
{
    class Program
    {
        static void PrintPassOrFail(int score)
        {
            if (score >= 50) 
            {
                Console.WriteLine("Passou!");
            }
            else
            {
                Console.WriteLine("Falhou!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("### Programa Checar Score(Pontuação) ###");

            Console.Write("Inserir Seu Nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine($"\n\tSeja bem-vindo {nomeCompleto}.");

            Console.Write("Inserir seu Score(pontuação): ");
            string totalScore = Console.ReadLine();
            int score = int.Parse(totalScore);

            Console.WriteLine($"\n\tPontuação {score}.");

            PrintPassOrFail(score);

            Console.ReadKey();
        }
    }
}
