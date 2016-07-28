using System;

namespace Program_Fow.Exemplos.EstruturasDeDecicao
{
    public class DeclaracaoIf
    {

        public DeclaracaoIf()
        {
            bool a = false;
            bool b = true;

            /*Se verdadeiro*/
            if (a)
            {
                Console.WriteLine("\"a\" é true");
            }
            /*Então se verdadeiro*/
            else if (b)
            {
                Console.WriteLine("\"b\" é true");
            }
            /*Então*/
            else
            {
                Console.WriteLine("\"a\" e \"b\" são false");
            }
        }
    }
}
