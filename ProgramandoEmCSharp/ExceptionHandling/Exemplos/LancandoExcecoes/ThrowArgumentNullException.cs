using System;

namespace ExceptionHandling.Exemplos.LancandoExcecoes
{
    public class ThrowArgumentNullException
    {

        public ThrowArgumentNullException()
        {
            Console.WriteLine("Digite um número inteiro:");

            try
            {
                ConverteNumero(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }

        private int ConverteNumero(string numero)
        {

            if (string.IsNullOrWhiteSpace(numero))
                throw new ArgumentNullException("numero", "Valor informado não deve ser nulo ou ser espaço em branco");

            return int.Parse(numero);
        }

    }
}
