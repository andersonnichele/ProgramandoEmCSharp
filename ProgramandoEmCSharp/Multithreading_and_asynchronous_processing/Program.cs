using System;
using System.Threading;

namespace Multithreading_and_asynchronous_processing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            t.Start();

            t.Join();

            Console.WriteLine("Pressione qualquer tecla para sair");

            Console.ReadKey();
        }
        
        public static void ThreadMethod()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Processando thread {0}", new String('.', i));
                Thread.Sleep(150);
            }
        }
    }
}
