using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks
{
    public class TasksFilhos
    {

        public TasksFilhos()
        {

            /*Task tera como retorno um vetor de string, cada elemento do vetor será gerado por um filho da task*/
            Task<string[]> task = Task.Run(() =>
            {
                var resultados = new string[3];

                new Task(() => resultados[0] = "Filho 1",
                TaskCreationOptions.AttachedToParent).Start();

                new Task(() => resultados[1] = "Filho 2",
                TaskCreationOptions.AttachedToParent).Start();

                new Task(() => resultados[2] = "Filho 3",
                TaskCreationOptions.AttachedToParent).Start();

                return resultados;
            });

            task.ContinueWith(
                taskGenitora => {
                    foreach (string i in taskGenitora.Result)
                        Console.WriteLine(i);
                });

            task.Wait();

            Console.ReadKey();
        }

    }
}
