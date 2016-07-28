using System;

namespace Program_Fow.Exemplos.IteracoesComColecoes
{
    public class LoopComWhileDoWhile
    {

        public LoopComWhileDoWhile()
        {
            int[] valores = { 1, 2, 3, 4, 5, 6 };

            int i = 0;

            /*Enquanto condição for false, o loop irá continuar*/
            while (i < valores.Length)
            {
                Console.WriteLine(valores[i]);
                i++;
            }

            /*Loop é executado até que a condição seja true. 
             * No do-while, o primeiro é executado a operação e depois verificado a condição
             */
            do
            {
                Console.WriteLine("DO!");
            }
            while (false);
        }
    }
}
