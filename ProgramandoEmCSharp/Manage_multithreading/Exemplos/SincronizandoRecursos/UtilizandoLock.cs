using System;
using System.Threading.Tasks;

namespace Manage_multithreading.Exemplos.SincronizandoRecursos
{
    public class UtilizandoLock
    {
        public UtilizandoLock()
        {
            int n = 0;
            object _lock = new object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    /*lock garante que um thread não entre em uma seção crítica do código 
                     * enquanto outro thread está na seção crítica
                     *fonte https://msdn.microsoft.com/pt-br/library/c5kehkcz.aspx
                     */
                    lock (_lock)
                        n++;
            });

            for (int i = 0; i < 1000000; i++)
                lock (_lock)
                    n--;

            up.Wait();

            Console.WriteLine(n);

            Console.ReadKey();
        }

    }
}
