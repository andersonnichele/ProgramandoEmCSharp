﻿using Multithreading_and_asynchronous_processing.Exemplos.EntendoThreads;
using Multithreading_and_asynchronous_processing.Exemplos.UtilizandoTasks;
using System;
using System.Diagnostics;

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

            //IniciarAguardarTask IniciarAguardarTask = new IniciarAguardarTask();

            #endregion
        }
    }
}
