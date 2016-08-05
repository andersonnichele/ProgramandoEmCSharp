using System;

namespace Events_Callbacks.Exemplos.UtilizandoEvents
{
    public class CustomizarAcessoEvent
    {
        public CustomizarAcessoEvent()
        {
            CustomizarAcessoEventClasse caec = new CustomizarAcessoEventClasse();

            caec.OnChange += (sender, e)
                => Console.WriteLine("Evento acionou: {0}", e.Valor);

            caec.Raise();
        }
    }

    public class CustomizarAcessoEventClasse
    {
        private event EventHandler<EventArgsCustomizado> onChange = delegate { };
        public event EventHandler<EventArgsCustomizado> OnChange
        {
            /*lock irá garantir que as operações de adicionar e remover são seguras em threads executas ao mesmo tempo */
            add
            {
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                }
            }
        }

        public void Raise()
        {
            onChange(this, new EventArgsCustomizado(42));
        }
    }
}
