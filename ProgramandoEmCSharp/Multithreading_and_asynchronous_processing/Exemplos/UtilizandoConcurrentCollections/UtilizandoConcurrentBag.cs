using System;
using System.Collections.Concurrent;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoConcurrentCollections
{
    public class UtilizandoConcurrentBag
    {

        public UtilizandoConcurrentBag()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            /*Add adiciona objetos no ConcurrentBag*/
            bag.Add(42);
            bag.Add(21);

            int resultado;

            /*TryTake remove e retorna um objeto da ConcurrentBag*/
            if (bag.TryTake(out resultado))
                Console.WriteLine(resultado);

            /*TryTake retorna um objeto da ConcurrentBag mas não remove ele*/
            if (bag.TryPeek(out resultado))
                Console.WriteLine("Próximo item: {0}", resultado);

            Console.ReadKey();
        }
    }
}
