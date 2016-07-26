using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Manage_multithreading.Exemplos.SincronizandoRecursos
{
    public class CriandoDeadlock
    {

        public CriandoDeadlock()
        {

            object lockA = new object();
            object lockB = new object();

            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Console.WriteLine("Lock A");

                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        Console.WriteLine("Lock B dentro do lock A");
                    }
                }
            });

            lock (lockB)
            {
                Console.WriteLine("Lock B");

                lock (lockA)
                {
                    Console.WriteLine("Lock A dentro do lock B");
                    Thread.Sleep(2000);
                }
            }
            up.Wait();

            Console.ReadKey();

        }
    }
}
