using System;

namespace Events_Callbacks.Exemplos.UtilizandoEvents
{
    public class ExceptionEvent
    {

        public ExceptionEvent()
        {
            ExceptionEventClasse eec = new ExceptionEventClasse();

            /*Será executado normalmente*/
            eec.OnChange += (sender, e) =>
                Console.WriteLine("Assinatura  1");

            /*Irá jogar uma exceção na aplicação*/
            eec.OnChange += (sender, e) =>
            {
                throw new Exception();
            };

            /*Nunca será executado*/
            eec.OnChange += (sender, e) =>
                Console.WriteLine("Assinatura  3");

            eec.Raise();
        }
    }

    public class ExceptionEventClasse
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, EventArgs.Empty);
        }
    }
}
