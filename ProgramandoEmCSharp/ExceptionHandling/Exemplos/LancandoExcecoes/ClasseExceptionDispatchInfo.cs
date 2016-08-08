using System;
using System.Runtime.ExceptionServices;

namespace ExceptionHandling.Exemplos.LancandoExcecoes
{
    public class ClasseExceptionDispatchInfo
    {

        public ClasseExceptionDispatchInfo()
        {
            ExceptionDispatchInfo possibleException = null;
            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                /*O stacktrace original será preservado*/
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }
            if (possibleException != null)
            {
                /*Exceção será lançada*/
                possibleException.Throw();
            }
        }
    }
}
