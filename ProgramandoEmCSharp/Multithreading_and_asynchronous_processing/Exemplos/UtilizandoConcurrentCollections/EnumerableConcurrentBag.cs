using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoConcurrentCollections
{
    public class EnumerableConcurrentBag
    {

        public EnumerableConcurrentBag()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(500);
                bag.Add(21);
            });

            /*Será exibido apenas o valor 42, pois o valor 21 ainda não foi adicionado 
             * no momento na execução desta Task
             */
            Task.Run(() =>
            {
                foreach (int i in bag)
                    Console.WriteLine(i);
            }).Wait();

            /*Nesta Task será aguardado 1s para aque o outro valor seja adicionado na ConcurrentBag*/
            Task.Run(() =>
            {
                Thread.Sleep(1001);

                foreach (int i in bag)
                    Console.WriteLine(i);
            }).Wait();

            Console.ReadKey();
        }
    }
}
