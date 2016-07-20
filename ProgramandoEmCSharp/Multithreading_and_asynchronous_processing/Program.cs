using Multithreading_and_asynchronous_processing.Exemplos.EntendoThreads;
using Multithreading_and_asynchronous_processing.Exemplos.UtilizandoClasseParallel;
using Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks;
using Multithreading_and_asynchronous_processing.Exemplos.UtilizandoAsyncEAwait;
using System;
using System.Diagnostics;
using Multithreading_and_asynchronous_processing.Exemplos.UtilizandoPLINQ;

namespace Multithreading_and_asynchronous_processing
{
    public class Program
    {
        static void Main(string[] args)
        {

            Process.Start("https://github.com/andersonnichele/ProgramandoEmCSharp/wiki");

            #region Entendendo Threads

            //ExecutandoMetodoEmUmaThread executandoMetodoEmUmaThread = new ExecutandoMetodoEmUmaThread();

            //PropriedadeBackground propriedadeBackground = new PropriedadeBackground();

            //ParametrizandoInicioThread parametrizandoInicioThread = new ParametrizandoInicioThread();

            //PararThread pararThread = new PararThread();

            //AtributoThreadStatic atributoThreadStatic = new AtributoThreadStatic();

            //ClasseThreadLocal ClasseThreadLocal = new ClasseThreadLocal();

            //ThreadPools threadPools = new ThreadPools();
            #endregion

            #region Utilizando Tasks

            //IniciarAguardarTask iniciarAguardarTask = new IniciarAguardarTask();

            //TaskComRetorno taskComRetorno = new TaskComRetorno();

            //TaskContinueWith taskContinueWith = new TaskContinueWith();

            //TasksContinuationOptions tasksContinuationOptions = new TasksContinuationOptions();

            //TasksFilhos tasksFilhos = new TasksFilhos();

            //FilhosComTaskFactory filhosComTaskFactory = new FilhosComTaskFactory();

            //TasksWaitAll tasksWaitAll = new TasksWaitAll();

            //TasksWaitAny tasksWaitAny = new TasksWaitAny();

            #endregion

            #region Utilizando a Classe Parallel

            //ParallelForEForeachcs parallelForEForeachcs = new ParallelForEForeachcs();

            //ParallelBreak parallelBreak = new ParallelBreak();

            #endregion

            #region Utilizando async e await

            //AsyncAwait AsyncAwait = new AsyncAwait();

            #endregion

            #region Utilizando Parallel Language Integrated Query (PLINQ)

            //UtilizandoAsParallel utilizandoAsParallel = new UtilizandoAsParallel();

            //QueryParallelOrdenada queryParallelOrdenada = new QueryParallelOrdenada();

            //QueryParallelSequencial queryParallelSequencial = new QueryParallelSequencial();

            //ParallelForAll parallelForAll = new ParallelForAll();

            //CatchingAggregateException catchingAggregateException = new CatchingAggregateException();

            #endregion
        }
    }
}
