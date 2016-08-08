using System;

namespace ExceptionHandling.Exemplos.TratandoExcecoes
{
    public class TryCatchFinally
    {

        public TryCatchFinally()
        {
            Console.WriteLine("Digite um número inteiro:");

            string s = Console.ReadLine();
            try
            {
                int i = int.Parse(s);
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor digitado é muito grande ou muito pequeno para o tipo Int32.");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} não é um número válido", s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*Independente do sucesso ou não da execução do bloco de código condidos no try
             *o trecho do finally será executado.
             */
            finally
            {
                Console.WriteLine("Operação finalizada");
            }
        }
    }
}
