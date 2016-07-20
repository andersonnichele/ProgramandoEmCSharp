using System;
using System.Linq;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoPLINQ
{
    public class QueryParallelSequencial
    {

        public QueryParallelSequencial()
        {
            var numeros = Enumerable.Range(0, 20);

            var parallelResultado = numeros
                .AsParallel()
                .AsOrdered()
                .Where(i => i % 2 == 0)
                /*Expressão Where será executada de forma que a sequência seja respeitada*/
                .AsSequential();

            foreach (int i in parallelResultado)
                Console.Write("{0} ", i);

            Console.ReadKey();
        }
    }
}
