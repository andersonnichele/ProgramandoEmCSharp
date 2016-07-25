using System;
using System.Collections.Concurrent;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoConcurrentCollections
{
    public class UtilizandoConcurrentQueue
    {

        public UtilizandoConcurrentQueue()
        {

            ConcurrentQueue<string> queue = new ConcurrentQueue<string>();

            /*Adicionado itens na fila*/
            queue.Enqueue("Primeiro");
            queue.Enqueue("Segundo");
            queue.Enqueue("Terceiro");

            string resultado;

            /*É retirado o primeiro item que foi inserido na fila*/
            if (queue.TryDequeue(out resultado))
                Console.WriteLine("{0} saiu da fila", resultado);

            Console.ReadKey();
        }
    }
}
