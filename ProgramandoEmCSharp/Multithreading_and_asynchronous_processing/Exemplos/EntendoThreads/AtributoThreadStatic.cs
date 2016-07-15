using System;
using System.Threading;

namespace Multithreading_and_asynchronous_processing.Exemplos.EntendoThreads
{
    public class AtributoThreadStatic
    {
        /*É definido um atributo para cada Thread*/
        [ThreadStatic]
        public static int _atributoThreadStatic;

        public AtributoThreadStatic()
        {

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    /*Idependente se outras Threads usem esse atributo, cada Threads terá seu próprio valor*/
                    _atributoThreadStatic++;
                    Console.WriteLine("Thread A: {0}", _atributoThreadStatic);

                    Thread.Sleep(100);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _atributoThreadStatic++;
                    Console.WriteLine("Thread B: {0}", _atributoThreadStatic);

                    Thread.Sleep(155);

                }
            }).Start();

            Console.ReadKey();
        }
    }
}
