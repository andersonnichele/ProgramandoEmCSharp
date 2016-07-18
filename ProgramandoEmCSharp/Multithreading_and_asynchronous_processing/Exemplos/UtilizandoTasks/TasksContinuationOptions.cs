using System;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks
{
    public class TasksContinuationOptions
    {

        public TasksContinuationOptions()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Task cancelada");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Task falhou");
            }, TaskContinuationOptions.OnlyOnFaulted);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Task finalizada");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            t.Wait();

            Console.ReadKey();

        }
    }
}
