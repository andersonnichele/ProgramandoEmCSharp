﻿using System;
using System.Threading;

namespace Multithreading_and_asynchronous_processing.Exemplos.EntendoThreads
{
    public class PararThread
    {

        public PararThread()
        {
            /*Variável utilizada para parar a Thread*/
            bool parado = false;

            Thread t = new Thread(new ThreadStart(() =>
            {
                /*Simula um loop infinito*/
                while (!parado)
                {
                    TextoProcessando(@"\");
                    TextoProcessando(@"|");
                    TextoProcessando(@"/");
                    TextoProcessando(@"-");
                }
            }));

            t.Start();

            /*Aguarda o usuário pressionar qualquer tecla para Thread sair do loop infinito*/
            Console.ReadKey();
            parado = true;

            t.Join();
        }

        public static void TextoProcessando(string caracter)
        {
            Console.Clear();

            Console.WriteLine("Processando {0}", caracter);
            Console.WriteLine("Pressione qualquer tecla para sair");

            Thread.Sleep(50);
        }
    }
}
