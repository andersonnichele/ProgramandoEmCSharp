using System;

namespace Events_Callbacks.Exemplos.UtilizandoDelegates
{
    public class MulticastingDelegate
    {
        public delegate void DeclaracaoDelegate();

        public MulticastingDelegate()
        {
            DeclaracaoDelegate del = MetodoUm;
            /*operador += adiciona mais um método*/
            del += MetodoDois;

            del();

        }

        public void MetodoUm()
        {
            Console.WriteLine("Método um");
        }
        public void MetodoDois()
        {
            Console.WriteLine("Método dois");
        }
    }
}
