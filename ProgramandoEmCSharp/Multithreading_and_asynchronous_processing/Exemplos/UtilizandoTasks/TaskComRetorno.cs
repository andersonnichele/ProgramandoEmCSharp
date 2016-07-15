using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks
{
    public class TaskComRetorno
    {

        public TaskComRetorno()
        {
            /*Instância do tipo Task criada terá um retorno do tipo int*/
            Task<int> t = Task.Run(() =>
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            });

            Console.WriteLine("Hoje, seu número da sorte é {0}", t.Result);
            Thread.Sleep(3000);
        }

    }
}
