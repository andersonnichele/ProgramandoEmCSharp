using System;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks
{
    public class FilhosComTaskFactory
    {

        public FilhosComTaskFactory()
        {
         
            Task<Int32[]> genitor = Task.Run(() =>
            {
                var results = new Int32[3];
                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                TaskContinuationOptions.ExecuteSynchronously);

                /*O método StartNew cria e inicializa as task filhas*/
                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);

                return results;
            });

            genitor.ContinueWith(
            parentTask => {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });

            genitor.Wait();

            Console.ReadKey();
        }
    }
}
