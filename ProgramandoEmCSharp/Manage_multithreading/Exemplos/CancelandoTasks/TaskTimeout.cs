using System;
using System.Threading;
using System.Threading.Tasks;

namespace Manage_multithreading.Exemplos.CancelandoTasks
{
    public class TaskTimeout
    {

        public TaskTimeout()
        {

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(100);
                }

            });

            int index = Task.WaitAny(new[] { task }, 5000);
            cancellationTokenSource.Cancel();

            if (index == -1)
                Console.WriteLine("\nTask timed out");

            Console.ReadKey();
        }
    }
}
