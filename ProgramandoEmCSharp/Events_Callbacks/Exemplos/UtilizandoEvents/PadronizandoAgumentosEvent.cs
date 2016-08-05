using System;

namespace Events_Callbacks.Exemplos.UtilizandoEvents
{
    public class PadronizandoAgumentosEvent
    {

        public PadronizandoAgumentosEvent()
        {

            PadronizandoAgumentosClasse pac = new PadronizandoAgumentosClasse();

            pac.OnChange += (sender, e)
                => Console.WriteLine("Evento acionou: {0}", e.Valor);

            pac.Raise();
        }
    }
    
    public class PadronizandoAgumentosClasse
    {
        public event EventHandler<EventArgsCustomizado> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new EventArgsCustomizado(42));
        }
    }
}
