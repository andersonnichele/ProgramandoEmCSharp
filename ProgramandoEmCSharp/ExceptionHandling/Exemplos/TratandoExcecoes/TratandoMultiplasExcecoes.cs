using System;

namespace ExceptionHandling.Exemplos.TratandoExcecoes
{
    public class TratandoMultiplasExcecoes
    {
        public TratandoMultiplasExcecoes()
        {
            while (true)
            {
                Console.WriteLine("Digite um número inteiro:");

                string s = Console.ReadLine();

                try
                {
                    int i = int.Parse(s);
                    break;
                }
                /*Se for digitado o valor 9999999999, por exemplo, irá extourar essa exceção */
                catch (OverflowException)
                {
                    Console.WriteLine("O valor digitado é muito grande ou muito pequeno para o tipo Int32.");
                }
                /*Caso seja uma exeção do tipo FormatException, esse bloco será executado*/
                catch (FormatException)
                {
                    Console.WriteLine("{0} não é um número válido", s);
                }
                /*Todas as exceções herdam a classe Exception. 
                 * Caso não seja uma exceção do tipo OverflowException ou FormatException,
                 *  será lançada para a Exception.  
                 *CUIDADO! Sempre que fazer o catch com multiplas exceções, o ultimo bloco deve ser com o Exception
                 * caso contrário, as outras exceções não terão a ação executada.
                 */
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
