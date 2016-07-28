using System;

namespace Program_Flow.Exemplos.ExpressoesBooleanas
{
    public class OperadoreLogicos
    {
        /**Operadores lógicos**/
        /***********************
        Operador    Descrição
        ||          OU
        &&          E
        ^           OU exclusivo
        ***********************/

        public OperadoreLogicos()
        {
            bool x = false;
            bool y = true;
            bool z = true;

            /*|| retorna true quando um dos dos operadores é true*/
            Console.WriteLine("{0} OU {1} OU {2}, algum desses é verdadeiro? {3}",x, y, z, x || y || z);

            /*&& retorna true quando todos os operadores são true*/
            Console.WriteLine("{0} E {1} E {2}, todos são verdadeiros? {3}", x, y, z, x && y && z);

            /*^ retorna true quando apenas um dos operadores é true*/
            Console.WriteLine("{0} OU EXCLUSIVO  {1} OU EXCLUSIVO {2}, somente um deles é verdadeiro? {3}", x, y, z, x ^ y ^ z);            
        }
    }
}
