using System;

namespace Events_Callbacks.Exemplos.UtilizandoEvents
{
    public class ActionEvent
    {
        public ActionEvent()
        {

            ActionEventClasse aec = new ActionEventClasse();

            aec.OnChange += () => Console.WriteLine("Evento acionado pele método 1");
            aec.OnChange += () => Console.WriteLine("Evento acionado pele método 2");

            aec.Raise();
        }
    }

    public class ActionEventClasse
    {
        public Action OnChange { get; set; }

        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }
    }
}
