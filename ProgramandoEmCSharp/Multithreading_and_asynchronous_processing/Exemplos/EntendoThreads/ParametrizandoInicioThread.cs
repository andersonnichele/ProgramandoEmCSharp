using System;
using System.Threading;

namespace Multithreading_and_asynchronous_processing.Exemplos.EntendoThreads
{
    public class ParametrizandoInicioThread
    {

        public ParametrizandoInicioThread()
        {
            Thread t = new Thread(new ParameterizedThreadStart(MetodoThread));

            /*Instância da Thread tem sua execução iniciada com a passagem de um parâmetro */
            t.Start(10);

            t.Join();
        }

        public static void MetodoThread(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                Console.WriteLine("Processando Thread {0} ", new String('.', i));
                Thread.Sleep(1000);
            }
        }
    }
}
