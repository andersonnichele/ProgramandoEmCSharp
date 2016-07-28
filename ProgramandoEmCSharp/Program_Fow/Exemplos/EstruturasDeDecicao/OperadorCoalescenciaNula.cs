using System;

namespace Program_Fow.Exemplos.EstruturasDeDecicao
{
    public class OperadorCoalescenciaNula
    {

        public OperadorCoalescenciaNula()
        {
            /*? após o a declarção do tipo da variaável indica ela aceita valores nulos*/

            int? x = null;
            /*Sendo o valor de x nulo, o valor de y será -1*/
            int? y = x ?? -1;

            Console.WriteLine("Valor de y é {0}", y);

            x = null;
            y = null;

            /*Sendo o valor de x  e y nulos, o valor de y será -2*/
            int z = x ?? y ?? -2;

            Console.WriteLine("Valor de z é {0}", z);
        }
    }
}
