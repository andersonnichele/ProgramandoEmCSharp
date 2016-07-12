using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos
{
    public class PropriedadeBackground
    {
        public PropriedadeBackground()
        {
            Thread tForeground = new Thread(new ThreadStart(MetodoThreadForeground));
            Thread tBackground = new Thread(new ThreadStart(MetodoThreadBackground));

            /*Cada instância terá uma valor diferente para identificar se ela será executada como Background*/
            tForeground.IsBackground = false;
            tBackground.IsBackground = true;

            /*Alterando o estado das Thread para executando*/
            tForeground.Start();
            tBackground.Start();

        }

        public static void MetodoThreadForeground()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("=> Executando Thread Foreground {0} de 10", i);
                Thread.Sleep(1000);
            }
        }

        public static void MetodoThreadBackground()
        {
            for (int i = 1; i < 51; i++)
            {
                Console.WriteLine("<= Executando Thread Background {0} de 50", i);
                Thread.Sleep(750);
            }
        }
    }
}
