using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoClasseParallel
{
    public class ParallelForEForeachcs
    {

        public ParallelForEForeachcs()
        {

            Random rnd = new Random();

            /*Os loops com Parallel.For ou Parallel.ForEach não são executados de forma sequencial */

            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(rnd.Next(500, 2000));

                Console.WriteLine("Finalizado iteração {0} do Parallel.For", i);
            });

            var numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(rnd.Next(500, 2000));

                Console.WriteLine("Finalizado iteração {0} do Parallel.ForEach", i);
            });
        }
    }
}
