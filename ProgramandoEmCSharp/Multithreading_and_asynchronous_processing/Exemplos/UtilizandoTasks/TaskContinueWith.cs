using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks
{
    public class TaskContinueWith
    {

        public TaskContinueWith()
        {
            /*Instância do tipo Task criada terá um retorno do tipo int*/
            Task<int> t = Task.Run(() =>
            {
                Random rnd = new Random();
                return rnd.Next(1, 50);
            }).ContinueWith((i) =>
            {
                Console.WriteLine("{0} não aparenta ser um bom número, vamos dobrar sua sorte ", i.Result);
                return i.Result * 2;
            });

            Console.WriteLine("Sorte dobrada, seu número é {0}", t.Result);

            Thread.Sleep(3000);
        }

    }
}
