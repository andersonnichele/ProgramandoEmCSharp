using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoConcurrentCollections
{
    public class UtilizandoBlockingCollection
    {

        public UtilizandoBlockingCollection()
        {
            Console.WriteLine("Digite algo e pressione enter:\n");

            BlockingCollection<string> blockingCol = new BlockingCollection<string>();

            Task ler = Task.Run(() =>
            {
                /*while true para que a task seja executada mais de uma vez*/
                while (true)
                {
                    Console.WriteLine("Você escreveu {0}", blockingCol.Take());
                }
            });

            Task escrever = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;

                    blockingCol.Add(s);
                }
            });

            escrever.Wait();
        }
    }
}
