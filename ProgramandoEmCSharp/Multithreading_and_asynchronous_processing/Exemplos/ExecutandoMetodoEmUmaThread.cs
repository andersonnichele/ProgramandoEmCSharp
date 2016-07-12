using System;
using System.Threading;


namespace Multithreading_and_asynchronous_processing.Exemplos
{
    public class ExecutandoMetodoEmUmaThread
    {

        public ExecutandoMetodoEmUmaThread()
        {
            /*Inicializa uma nova instância da classe Thread*/
            Thread t = new Thread(new ThreadStart(MetodoThread));

            /* Altera o estado da instância para executando
             * Os estado são identificados no enumerador System.Threading.ThreadState
             * Mais: https://msdn.microsoft.com/pt-br/library/system.threading.threadstate(v=vs.110).aspx
             */
            t.Start();

            /*Bloquei a chamada da Thread até ela terminar */
            t.Join();
        }

        public static void MetodoThread()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Processando thread {0}", new String('.', i));
                Thread.Sleep(150);
            }
        }

    }
}
