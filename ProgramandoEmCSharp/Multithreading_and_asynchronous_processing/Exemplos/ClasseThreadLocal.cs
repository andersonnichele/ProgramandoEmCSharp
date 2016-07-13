using System;
using System.Threading;

namespace Multithreading_and_asynchronous_processing.Exemplos
{
    public class ClasseThreadLocal
    {
        public static ThreadLocal<int> _threadLocal =
            new ThreadLocal<int>(() =>
            {
                /*Será retornado um valor unico que identifica uma Thread */
                return Thread.CurrentThread.ManagedThreadId;
            });

        public ClasseThreadLocal()
        {
            new Thread(() =>
            {
                for (int x = 0; x < _threadLocal.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _threadLocal.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _threadLocal.Value; x++)
                {
                    Console.WriteLine("Thread C: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
