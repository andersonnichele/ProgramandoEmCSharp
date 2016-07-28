using System;

namespace Program_Fow.Exemplos.EstruturasDeDecicao
{
    public class SwicthComGoto
    {

        public SwicthComGoto()
        {
            int i = 1;

            switch (i)
            {
                case 1:

                    Console.WriteLine("Case 1");
                    /*Desvia o fluxo para o case 3*/
                    goto case 3;

                case 2:

                    Console.WriteLine("Case 2");
                    break;

                case 3:

                    Console.WriteLine("Case 2");
                    break;
            }
        }
    }
}
