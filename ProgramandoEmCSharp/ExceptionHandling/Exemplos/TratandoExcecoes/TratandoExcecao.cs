using System;

namespace ExceptionHandling.Exemplos.TratandoExcecoes
{
    public class TratandoExcecao
    {

        public TratandoExcecao()
        {
            while (true)
            {
                Console.WriteLine("Digite um número inteiro:");

                string s = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s)) break;

                /*A utilização dos operadores try/catch são para tratamento de exceções*/
                try
                {
                    int i = int.Parse(s);
                    break;
                }
                /*Exceções do tipo FormatException serão tratadas neste trecho*/
                catch (FormatException)
                {
                    Console.WriteLine("{0} não é um número válido", s);
                }
            }
        }
    }
}
