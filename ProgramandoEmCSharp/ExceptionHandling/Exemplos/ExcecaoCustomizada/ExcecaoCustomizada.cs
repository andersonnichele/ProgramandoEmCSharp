using System;
using System.Runtime.Serialization;

namespace ExceptionHandling.Exemplos.ExcecaoCustomizada
{
    public class ExcecaoCustomizada
    {

        public ExcecaoCustomizada()
        {
            Console.WriteLine("Digite um nome diferente de Paulo");

            try
            {
                string nome = GetNome();
                Console.WriteLine("olá {0}", nome);
            }
            catch (MinhaException mex)
            {
                Console.WriteLine(mex.Message);
                Console.WriteLine("Visite {0} para maiores informações sobre Exceptions", mex.HelpLink);
            }
            
        }

        private string GetNome()
        {
            string s = Console.ReadLine();

            if (s.Equals("Paulo"))
                throw new MinhaException();

            return s;
        }
    }

    [Serializable]
    public class MinhaException : Exception, ISerializable
    {

        public MinhaException()
            : base("Nome não permitido")
        {
            this.HelpLink = "https://msdn.microsoft.com/pt-br/library/system.exception(v=vs.110).aspx";
        }
    }
}
