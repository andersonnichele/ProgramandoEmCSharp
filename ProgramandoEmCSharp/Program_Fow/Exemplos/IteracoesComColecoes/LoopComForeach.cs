using System;
using System.Collections.Generic;

namespace Program_Fow.Exemplos.IteracoesComColecoes
{
    public class LoopComForeach
    {

        public LoopComForeach()
        {
            int[] valores = { 1, 2, 3, 4, 5, 6 };

            foreach (int i in valores)
            {
                Console.Write(i);
            }

            /*Alterando valores dentro do foreach*/
            var people = new List<Person>
            {
                new Person() { FirstName = "João", LastName = "Silva"},
                new Person() { FirstName = "Pedro", LastName = "Silva"},
            };

            foreach (Person p in people)
            {
                p.LastName = "da Silva";
                /* p = new Person(); irá resultar em erro de compilação*/
            }
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
