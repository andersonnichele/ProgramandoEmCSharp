using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Callbacks.Exemplos.UtilizandoLambda
{
    public class ActionDelegate
    {

        public ActionDelegate()
        {

            /*Pode ser adicionados de 0 a 16 parametros*/
            Action<int, int> calc1 = (x, y) =>
            {
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            };

            calc1(3, 4);

            Action<int, int, int> calc2 = (x, y, z) =>
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", x, y, z , x + y + z);
            };

            calc2(3, 4, 5); 

        }
    }
}
