using System;

namespace Program_Fow.Exemplos.IteracoesComColecoes
{
    public class LoopComFor
    {

        public LoopComFor()
        {
            int[] valores = { 1, 2, 3, 4, 5, 6 };

            /*for (valor inicial; condição; incremento)*/

            Console.WriteLine("Loop for simples");
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write(valores[i]);
            }

            Console.WriteLine("\nLoop for com multiplas variaveis no loop");
            for (int x = 0, y = valores.Length - 1;
                ((x < valores.Length) && (y >= 0));
                x++, y--)
            {
                Console.Write(valores[x]);
                Console.Write(valores[y]);
            }

            Console.WriteLine("\nLoop for com incremento customizado");
            for (int i = 0; i < valores.Length; i += 2)
            {
                Console.Write(valores[i]);
            }

            Console.WriteLine("\nLoop for com break");
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == 4) break;
                Console.Write(valores[i]);
            }

            Console.WriteLine("\nLoop for com continue");
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == 4) continue;
                Console.Write(valores[i]);
            }

        }
    }
}
