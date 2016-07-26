using Manage_multithreading.Exemplos.CancelandoTasks;
using Manage_multithreading.Exemplos.SincronizandoRecursos;
using System;
using System.Diagnostics;


namespace Manage_multithreading
{
    class Program
    {
        static void Main(string[] args)
        {

            Process.Start("https://github.com/andersonnichele/ProgramandoEmCSharp/wiki");

            #region Sincronizando Recursos

            //UtilizandoLock utilizandoLock = new UtilizandoLock();

            //CriandoDeadlock criandoDeadlock = new CriandoDeadlock();

            //InterlockedClass interlockedClass = new InterlockedClass();            

            #endregion

            #region Cancelando Tasks

            //UtilizandoCancellationToken utilizandoCancellationToken = new UtilizandoCancellationToken();

            //ThrowingCancellationToken throwingCancellationToken = new ThrowingCancellationToken();

            //TaskTimeout taskTimeout = new TaskTimeout();

            #endregion

        }
    }
}
