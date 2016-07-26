using System;
using System.Threading;
using System.Threading.Tasks;

namespace Manage_multithreading.Exemplos.CancelandoTasks
{
    public class UtilizandoCancellationToken
    {

        public UtilizandoCancellationToken()
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
            }, token);

            Console.WriteLine("Pressione enter para cancelar a task");
            Console.ReadLine();

            cancellationTokenSource.Cancel();

            Console.WriteLine("Pressione enter para fechar a aplicação");
            Console.ReadLine();
        }
    }
}
