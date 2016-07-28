using System;

namespace Program_Fow.Exemplos.EstruturasDeDecicao
{
    public class DeclaracaoSwitchCase
    {

        public DeclaracaoSwitchCase()
        {

            string input = "4";

            switch (input)
            {
                case "1":

                    Console.WriteLine("Valor inserido é valido");
                    break;

                case "2":

                    Console.WriteLine("Valor inserido também é valido");
                    break;

                default:
                    Console.WriteLine("O valor inserido não é valido");

                    break;

            }
        }
    }
}
