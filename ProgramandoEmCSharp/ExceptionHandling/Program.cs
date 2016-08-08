using ExceptionHandling.Exemplos.ExcecaoCustomizada;
using ExceptionHandling.Exemplos.LancandoExcecoes;
using ExceptionHandling.Exemplos.TratandoExcecoes;
using System;
using System.Diagnostics;


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            Process.Start("https://github.com/andersonnichele/ProgramandoEmCSharp/wiki");

            #region Tratando exceções

            //ConversaoInvalida conversaoInvalida = new ConversaoInvalida();

            //TratandoExcecao tratandoExcecao = new TratandoExcecao();

            //TratandoMultiplasExcecoes tratandoMultiplasExcecoes = new TratandoMultiplasExcecoes();

            //TryCatchFinally TryCatchFinally = new TryCatchFinally();

            //UtilizandoEnvironmentFailFast utilizandoEnvironmentFailFast = new UtilizandoEnvironmentFailFast();

            //InspecionandoExcecoes inspecionandoExcecoes = new InspecionandoExcecoes();

            #endregion

            #region Lançando exceções

            //ThrowArgumentNullException throwArgumentNullException = new ThrowArgumentNullException();

            //ClasseExceptionDispatchInfo classeExceptionDispatchInfo = new ClasseExceptionDispatchInfo();

            //ExcecoesComuns excecoesComuns = new ExcecoesComuns();

            #endregion

            #region Exceção customizada

            //ExcecaoCustomizada excecaoCustomizada = new ExcecaoCustomizada();

            #endregion

            Console.ReadKey();

        }
    }
}
