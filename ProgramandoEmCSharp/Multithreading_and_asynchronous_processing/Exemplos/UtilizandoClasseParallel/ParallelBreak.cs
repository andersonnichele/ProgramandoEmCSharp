using System;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoClasseParallel
{
    public class ParallelBreak
    {
        public ParallelBreak()
        {            
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {                
                Console.WriteLine("Iteração {0}", i);

                /*Execução do loop deverá ser cessada se passar pela iteração 500*/
                if (i == 500)
                {
                    Console.WriteLine("Iteração {0} encontrada, loop deverá ser cessado", i);
                    loopState.Break();
                }
                return;
            });

            Console.ReadKey();
        }
    }
}
