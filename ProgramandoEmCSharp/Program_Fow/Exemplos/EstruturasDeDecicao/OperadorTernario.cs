using System;

namespace Program_Fow.Exemplos.EstruturasDeDecicao
{
    public class OperadorTernario
    {

        public OperadorTernario()
        {
            bool valor = false;

            bool resultado;

            /*Se valor for true, resultado recebe true, se não, recebe false*/
            resultado = valor == true ? true : false;

            Console.WriteLine("resultado é {0}", resultado);

            /* Expressão acima pode ser representada desta maneira:
            if (valor)
                resultado = true;
            else
                resultado = false;
            */

        }
    }
}

