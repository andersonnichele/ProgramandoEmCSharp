using System;
using System.Threading;
using System.Threading.Tasks;

namespace Manage_multithreading.Exemplos.CancelandoTasks
{
    public class ThrowingCancellationToken
    {

        public ThrowingCancellationToken()
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
                /*Um exceção é lançada quando o cancelamento for requisitado*/
                token.ThrowIfCancellationRequested();
            }, token);

            try
            {
                Console.WriteLine("Pressione enter para cancelar a task");
                Console.ReadLine();

                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }

            Console.WriteLine("Pressione enter para fechar a aplicação");
            Console.ReadLine();
        }
    }
}
