using System;

namespace Events_Callbacks.Exemplos.UtilizandoDelegates
{
    public class UtilizandoDelegate
    {

        /*Declaração do delegate, definindo a assinatura requerida */
        public delegate int Calcular(int x, int y);
        public int Adiciona(int x, int y) { return x + y; }
        public int Multiplica(int x, int y) { return x * y; }

        public UtilizandoDelegate()
        {
            /*Instancia o delegate com o nome do método*/
            Calcular calc = Adiciona;
            Console.WriteLine(calc(3, 4));

            calc = Multiplica;
            Console.WriteLine(calc(3, 4));
        }

    }
}
