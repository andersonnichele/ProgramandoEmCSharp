using Multithreading_and_asynchronous_processing.Exemplos;
using System;

namespace Multithreading_and_asynchronous_processing
{
    public class Program
    {
        static void Main(string[] args)
        {            
            Menu();
        }

        static void Menu()
        {            

            ConfigurarCorDaFonte(ConsoleColor.Green);

            Console.WriteLine("\n**********Usando a classe Thread**********\n");

            ConfigurarCorDaFonte(ConsoleColor.Gray);

            Console.WriteLine("1 - Executando método em uma Thread");
            
            Console.WriteLine("\n0 - Sair \n");

            Selecionaropcao();
        }

        static void ConfigurarCorDaFonte(ConsoleColor corDaFonte)
        {
            Console.ForegroundColor = corDaFonte;
        }
        static void Selecionaropcao()
        {

            string opcaoSelecionada = Console.ReadLine();

            switch (opcaoSelecionada)
            {
                case "0":
                    Console.Beep();
                    Environment.Exit(0);
                    break;
                case "1":
                    ExecutandoMetodoEmUmaThread executandoMetodoEmUmaThread = new ExecutandoMetodoEmUmaThread();
                    break;
                default:
                    Console.Beep();
                    Console.WriteLine("\nOpção inválida\n");
                    break;
            }
           
            Menu();
        }

    }
}
