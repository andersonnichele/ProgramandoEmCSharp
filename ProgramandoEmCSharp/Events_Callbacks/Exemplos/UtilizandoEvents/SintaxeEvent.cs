using System;

namespace Events_Callbacks.Exemplos.UtilizandoEvents
{
    public class SintaxeEvent
    {
        public SintaxeEvent()
        {

            SintaxeEventClasse sec = new SintaxeEventClasse();

            sec.OnChange += () => Console.WriteLine("Evento acionado pele método 1");
            sec.OnChange += () => Console.WriteLine("Evento acionado pele método 2");

            sec.Raise();
        }

    }

    public class SintaxeEventClasse
    {
        /*Com o event, o OnChage passou de uma propriedade public para um campo público.
        *O event não pode ser diretamente assinado.                         
        */
        public event Action OnChange = delegate { };

        public void Raise()
        {
            OnChange();
        }
    }
}
