using System;

namespace Program_Flow.Exemplos.ExpressoesBooleanas
{
    public class OperadoresRelacionais
    {
        /**********Operadores relacionais**********/
        /******************************************
        Operador    Descrição               Exemplo
        <           Menor que               x < 42;
        >           Maior que               x > 42;
        <=          Menor que ou igual a    x <= 42;
        >=          Maior que ou igual a    x >= 42;
        ==          Igual a                 x == 42;
        !=          Diferente de            x != 42;                                       
        *******************************************/

        public OperadoresRelacionais()
        {
            
            int numero1 = 1;
            int numero2 = 2;
            
            Console.WriteLine("{0} é menor que {1}? {2}", numero1, numero2, numero1 < numero2);
            Console.WriteLine("{0} é maior que {1}? {2}", numero1, numero2, numero1 > numero2);
            Console.WriteLine("{0} é menor que ou igual a {1}? {2}", numero1, numero2, numero1 <= numero2);
            Console.WriteLine("{0} é maior que ou igual a {1}? {2}", numero1, numero2, numero1 >= numero2);
            Console.WriteLine("{0} é igual a {1}? {2}", numero1, numero2, numero1 == numero2);
            Console.WriteLine("{0} é diferente de {1}? {2}", numero1, numero2, numero1 < numero2);

        }
    }
}
