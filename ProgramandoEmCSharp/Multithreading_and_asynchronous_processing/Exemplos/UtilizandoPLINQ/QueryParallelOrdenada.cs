using System;
using System.Linq;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoPLINQ
{
    public class QueryParallelOrdenada
    {

        public QueryParallelOrdenada()
        {
            var numeros = Enumerable.Range(0, 20);

            var parallelResultado = numeros
                .AsParallel()
                /*Ordena a lista*/
                .AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (int i in parallelResultado)
                Console.Write("{0} ",i);

            Console.ReadKey();
        }

    }
}
