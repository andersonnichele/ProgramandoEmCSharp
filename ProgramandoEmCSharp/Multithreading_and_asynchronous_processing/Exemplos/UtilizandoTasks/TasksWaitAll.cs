using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks
{
    public class TasksWaitAll
    {

        public TasksWaitAll()
        {
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() => {

                Console.WriteLine("Início Filho 1");

                Thread.Sleep(1000);

                Console.WriteLine("Fim Filho 1");

                return 1;
            });

            tasks[1] = Task.Run(() => {

                Console.WriteLine("Início Filho 2");

                Thread.Sleep(900);

                Console.WriteLine("Fim Filho 2");

                return 2;
            });

            tasks[2] = Task.Run(() => {

                Console.WriteLine("Início Filho 3");

                Thread.Sleep(950);

                Console.WriteLine("Fim Filho 3");

                return 3;
            }

            );

            /*Task irá aguardar a finalização de todas as Tasks filhos*/
            Task.WaitAll(tasks);

            Console.ReadKey();
        }
    }
}
