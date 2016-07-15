using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks
{
    public class IniciarAguardarTask
    {

        public IniciarAguardarTask()
        {
            /*Cria uma instância do tipo Task e imediatamente é iniciada*/
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write("*");
                    Thread.Sleep(25);
                }
            });

            /*Aguarda Task finalizar a execução.
             * o Wait é similar ao Join da classe Thread
             */
            t.Wait();
        }
    }
}
