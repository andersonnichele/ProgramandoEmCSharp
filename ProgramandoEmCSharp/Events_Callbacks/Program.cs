using Events_Callbacks.Exemplos.UtilizandoDelegates;
using Events_Callbacks.Exemplos.UtilizandoEvents;
using Events_Callbacks.Exemplos.UtilizandoLambda;
using System;
using System.Diagnostics;

namespace Events_Callbacks
{
    class Program
    {
        static void Main(string[] args)
        {

            Process.Start("https://github.com/andersonnichele/ProgramandoEmCSharp/wiki");

            #region Utilizando Delegates

            //UtilizandoDelegate utilizandoDelegate = new UtilizandoDelegate();

            //MulticastingDelegate multicastingDelegate = new MulticastingDelegate();

            #endregion

            #region Utilizando Lambda

            //LambdaCriandoDelegate lambdaCriandoDelegate = new LambdaCriandoDelegate();

            //ActionDelegate actionDelegate = new ActionDelegate();

            #endregion

            #region Utilizando events

            //ActionEvent actionEvent = new ActionEvent();

            //SintaxeEvent sintaxeEvent = new SintaxeEvent();

            //PadronizandoAgumentosEvent padronizandoAgumentosEvent = new PadronizandoAgumentosEvent();

            //CustomizarAcessoEvent customizarAcessoEvent = new CustomizarAcessoEvent();

            //ExceptionEvent exceptionEvent = new ExceptionEvent();

            //TratamentoExcecaoEvent tratamentoExcecaoEvent = new TratamentoExcecaoEvent();

            #endregion
            Console.ReadKey();
        }
    }
}
