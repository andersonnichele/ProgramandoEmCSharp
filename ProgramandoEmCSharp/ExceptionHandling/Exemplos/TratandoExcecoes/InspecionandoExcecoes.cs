using System;

namespace ExceptionHandling.Exemplos.TratandoExcecoes
{
    public class InspecionandoExcecoes
    {

        public InspecionandoExcecoes()
        {
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Message: {0}",fe.Message);
                Console.WriteLine("StackTrace: {0}", fe.StackTrace);
                Console.WriteLine("HelpLink: {0}", fe.HelpLink);
                Console.WriteLine("InnerException: {0}", fe.InnerException);
                Console.WriteLine("TargetSite: {0}", fe.TargetSite);
                Console.WriteLine("Source: {0}", fe.Source);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("StackTrace: {0}", ex.StackTrace);
                Console.WriteLine("HelpLink: {0}", ex.HelpLink);
                Console.WriteLine("InnerException: {0}", ex.InnerException);
                Console.WriteLine("TargetSite: {0}", ex.TargetSite);
                Console.WriteLine("Source: {0}", ex.Source);
            }
            finally
            {
                Console.WriteLine("Operação finalizada");
            }
        }
    }
}
