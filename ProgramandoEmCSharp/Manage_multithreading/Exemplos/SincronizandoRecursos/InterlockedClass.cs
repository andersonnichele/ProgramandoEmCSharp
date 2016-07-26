using System;
using System.Threading;
using System.Threading.Tasks;

namespace Manage_multithreading.Exemplos.SincronizandoRecursos
{
    public class InterlockedClass
    {

        public InterlockedClass()
        {

            int n = 0;

            /*Interlocked garante que as operações de incremento e decremento serão executadas atomicamentes*/

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n);
            });

            for (int i = 0; i < 1000000; i++)
                Interlocked.Decrement(ref n);

            up.Wait();

            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
