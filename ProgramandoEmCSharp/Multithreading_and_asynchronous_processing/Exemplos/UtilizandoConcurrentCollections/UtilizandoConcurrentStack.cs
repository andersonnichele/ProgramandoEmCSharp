using System;
using System.Collections.Concurrent;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoConcurrentCollections
{
    public class UtilizandoConcurrentStack
    {

        public UtilizandoConcurrentStack()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            /*Empilha um item na pilha*/
            stack.Push(42);

            int result;

            /*Desempilha um item da pilha*/
            if (stack.TryPop(out result))
                Console.WriteLine("Desempilhado: {0}", result);

            /*Empilha vários itens na pilha*/
            stack.PushRange(new int[] { 1, 2, 3 });

            int[] valores = new int[2];

            /*Desempilha vários itens e retorna para um objeto
             * neste exemplo é desempilhado dois itens da pilha para o objeto valores
             */
            stack.TryPopRange(valores);

            foreach (int i in valores)
                Console.WriteLine(i);

            Console.ReadKey();
        }

    }
}
