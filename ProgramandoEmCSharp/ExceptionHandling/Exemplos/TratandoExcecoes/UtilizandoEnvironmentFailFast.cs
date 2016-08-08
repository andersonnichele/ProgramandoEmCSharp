using System;

namespace ExceptionHandling.Exemplos.TratandoExcecoes
{
    public class UtilizandoEnvironmentFailFast
    {

        public UtilizandoEnvironmentFailFast()
        {
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);

                if (i == 42)
                    /*Environment.FailFast encerra imediatamente o processo
                     *  depois de gravar uma mensagem no log de eventos do aplicativo do Windows
                     */
                    Environment.FailFast("Número 42 foi digitado");
            }
            finally
            {
                Console.WriteLine("Operação finalizada");
            }
        }
    }
}
