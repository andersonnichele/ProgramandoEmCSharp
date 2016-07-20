using System.Linq;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoPLINQ
{
    public class UtilizandoAsParallel
    {
        public UtilizandoAsParallel()
        {
            var numeros = Enumerable.Range(0, 100000000);

            /*AsParallel indica que a operação LINQ será executada de forma paralela */
            var parallelResultado = numeros.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
        }
    }
}
