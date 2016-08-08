namespace ExceptionHandling.Exemplos.TratandoExcecoes
{
    public class ConversaoInvalida
    {

        public ConversaoInvalida()
        {
            string s = "ABC";

            /*Conversão sem tratamento, será lançado um exceção do tipo FormatException*/
            int i = int.Parse(s);
        }
    }
}
