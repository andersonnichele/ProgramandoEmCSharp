using System;

namespace Events_Callbacks.Exemplos.UtilizandoEvents
{
    public class EventArgsCustomizado : EventArgs
    {
        public int Valor { get; set; }

        public EventArgsCustomizado(int valor)
        {
            Valor = valor;
        }
    }
}
