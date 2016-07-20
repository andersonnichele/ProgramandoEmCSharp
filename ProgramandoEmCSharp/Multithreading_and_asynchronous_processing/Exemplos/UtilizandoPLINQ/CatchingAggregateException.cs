using System;
using System.Linq;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoPLINQ
{
    public class CatchingAggregateException
    {

        public CatchingAggregateException()
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                var parallelResult = numbers
                    .AsParallel()
                    .Where(i => IsEven(i));

                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Existem {0} exceções", e.InnerExceptions.Count);
            }
        }
        public static bool IsEven(int i)
        {
            /*Para teste, caso resto da divisão por 10 seja 0, será simulado uma exceção */
            if (i % 10 == 0) throw new ArgumentException();
            return i % 2 == 0;
        }
    }
}
