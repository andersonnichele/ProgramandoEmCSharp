using System;
using System.Threading;

namespace Multithreading_and_asynchronous_processing.Exemplos.EntendoThreads
{

    /*Adaptado de https://msdn.microsoft.com/pt-br/library/mt679040.aspx */
    public class ThreadPools
    {
        public ThreadPools()
        {
            const int FibonacciCalculations = 10;

            // Um evento é utilizado para cada objeto do tipo Fibonacci.
            ManualResetEvent[] doneEvents = new ManualResetEvent[FibonacciCalculations];
            Fibonacci[] fibArray = new Fibonacci[FibonacciCalculations];
            Random r = new Random();

            // Configurando e inicializando as threads utilziando ThreadPool.
            Console.WriteLine("Inicialiazado {0} tasks...", FibonacciCalculations);
            for (int i = 0; i < FibonacciCalculations; i++)
            {
                doneEvents[i] = new ManualResetEvent(false);
                Fibonacci f = new Fibonacci(r.Next(20, 40), doneEvents[i]);
                fibArray[i] = f;
                ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, i);
            }

            // Aguarda todas as threads no pool realziar o calculo.
            WaitHandle.WaitAll(doneEvents);
            Console.WriteLine("Calculos concluídos.");

            // Exibir resultados.
            for (int i = 0; i < FibonacciCalculations; i++)
            {
                Fibonacci f = fibArray[i];
                Console.WriteLine("Fibonacci({0}) = {1}", f.N, f.FibOfN);
            }

            Console.ReadKey();
        }
    }

    /*Para saber mais sobre a Sequência de Fibonacci de https://pt.wikipedia.org/wiki/Sequ%C3%AAncia_de_Fibonacci*/
    public class Fibonacci
    {
        private int _n;
        private int _fibOfN;
        private ManualResetEvent _doneEvent;

        public int N { get { return _n; } }
        public int FibOfN { get { return _fibOfN; } }

        // Constructor.
        public Fibonacci(int n, ManualResetEvent doneEvent)
        {
            _n = n;
            _doneEvent = doneEvent;
        }

        // Métono wrapper para ser usado no thread pool.
        public void ThreadPoolCallback(Object threadContext)
        {
            int threadIndex = (int)threadContext;
            Console.WriteLine("Thread {0} inicializada...", threadIndex);
            _fibOfN = Calcular(_n);
            Console.WriteLine("Thread {0} resultado calculado...", threadIndex);
            _doneEvent.Set();
        }

        /*Função recursiva para fazer o calculo da sequência Fibonacci */
        public int Calcular(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Calcular(n - 1) + Calcular(n - 2);
        }
    }
}
