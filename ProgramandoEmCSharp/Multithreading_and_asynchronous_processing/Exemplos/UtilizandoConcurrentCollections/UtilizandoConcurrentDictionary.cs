using System;
using System.Collections.Concurrent;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoConcurrentCollections
{
    public class UtilizandoConcurrentDictionary
    {

        public UtilizandoConcurrentDictionary()
        {
            var dict = new ConcurrentDictionary<string, int>();

            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Adicionado ao dicionário valor {0} com a chave \"k1\"", dict["k1"]);
            }

            if (dict.TryAdd("k2", 21))
            {
                Console.WriteLine("Adicionado ao dicionário valor {0} com a chave \"k2\"", dict["k2"]);
            }

            if (dict.TryUpdate("k1", dict["k2"], 42))
            {
                Console.WriteLine("Alterado o valor do \"k1\" para {0}", dict["k2"]);
            }

            dict.AddOrUpdate("k1", 3, (s, i) => i * 2);

            dict.GetOrAdd("k3", 3);


        }
    }
}
