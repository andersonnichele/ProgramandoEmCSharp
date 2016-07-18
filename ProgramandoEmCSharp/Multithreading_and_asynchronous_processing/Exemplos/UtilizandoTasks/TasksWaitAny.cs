using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks
{
    public class TasksWaitAny
    {
        public TasksWaitAny()
        {
            Task<string>[] tasks = new Task<string>[3];

            Random rnd = new Random();

            /*3 Tasks são criada, e antes de retornar um valor, aguarda entre 1 e 4 segundos (aleatoriamente)*/
            tasks[0] = Task.Run(() => { Thread.Sleep(rnd.Next(1000, 4000)); return "Filho 1"; });
            tasks[1] = Task.Run(() => { Thread.Sleep(rnd.Next(1000, 4000)); return "Filho 2"; });
            tasks[2] = Task.Run(() => { Thread.Sleep(rnd.Next(1000, 4000)); return "Filho 3"; });

            while (tasks.Length > 0)
            {
                /*Aguarda a finalização de qualquer um dos filhos*/
                int i = Task.WaitAny(tasks);

                Task<string> completedTask = tasks[i];

                Console.WriteLine(completedTask.Result);

                var temp = tasks.ToList();

                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }

            Console.ReadKey();
        }
    }
}

