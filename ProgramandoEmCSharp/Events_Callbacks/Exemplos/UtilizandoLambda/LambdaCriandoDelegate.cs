using System;

namespace Events_Callbacks.Exemplos.UtilizandoLambda
{
    public class LambdaCriandoDelegate
    {

        public delegate int DeclaracaoDelegate(int x, int y);

        public LambdaCriandoDelegate()
        {
            /*Define método do delegate com uma expessão Lambda*/
            DeclaracaoDelegate del =
                (x, y) =>
                {
                    /*Mais que uma operação pode ser adicionada na expressão*/
                    Console.WriteLine("Somando {0} com {1}", x, y);
                    return x + y;
                };
                
            Console.WriteLine(del(3, 4));

            del = (x, y) =>
            {
                Console.WriteLine("Multiplicando {0} com {1}", x, y);
                return x + y;
            };

            Console.WriteLine(del(3, 4));
        }
    }
}
