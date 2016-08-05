using System;
using System.Collections.Generic;
using System.Linq;

namespace Events_Callbacks.Exemplos.UtilizandoEvents
{
    public class TratamentoExcecaoEvent
    {

        public TratamentoExcecaoEvent()
        {
            TratamentoExcecaoEventClasse teec = new TratamentoExcecaoEventClasse();

            teec.OnChange += (sender, e) =>
                Console.WriteLine("Assinatura  1");

            teec.OnChange += (sender, e) =>
            {
                throw new Exception();
            };

            teec.OnChange += (sender, e) =>
                Console.WriteLine("Assinatura  3");

            try
            {
                teec.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Número de exceções: {0}", ex.InnerExceptions.Count);
            }
        }
    }

    public class TratamentoExcecaoEventClasse
    {
        public event EventHandler OnChange = delegate { };

        public void Raise()
        {
            var exceptions = new List<Exception>();

            foreach (Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
