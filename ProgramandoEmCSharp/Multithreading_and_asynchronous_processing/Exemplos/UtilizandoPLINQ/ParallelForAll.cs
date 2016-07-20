using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoPLINQ
{
    public class ParallelForAll
    {

        public ParallelForAll()
        {

            var numeros = Enumerable.Range(0, 20);

            var parallelResultado = numeros
                .AsParallel()
                .Where(i => i % 2 == 0);

            /*Iteração de forma paralela*/
            parallelResultado.ForAll(e => Console.Write("{0} ", e));

            Console.ReadKey();
        }
    }
}
