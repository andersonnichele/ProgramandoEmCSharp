using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoConcurrentCollections
{
    public class GetConsumingEnumerableBlockingCollection
    {

        public GetConsumingEnumerableBlockingCollection()
        {
            
            BlockingCollection<string> blockingCol = new BlockingCollection<string>();

            Task ler = Task.Run(() =>
            {
                Console.WriteLine("Digite algo e pressione enter:\n");

                /*GetConsumingEnumerable irá consumir um IEnumerable que será bloqueado até encontrar outro item
                 *com isso, não faz necessário o while true (ver classe UtilizandoBlockingCollection )
                 */
                foreach (string v in blockingCol.GetConsumingEnumerable())
                    Console.WriteLine("Você escreveu {0}", v);
            });

            Task escrever = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;

                    blockingCol.Add(s);
                }
            });

            escrever.Wait();

        }
    }
}
