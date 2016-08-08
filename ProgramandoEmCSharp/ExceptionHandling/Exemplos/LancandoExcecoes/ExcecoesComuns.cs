using System;

namespace ExceptionHandling.Exemplos.LancandoExcecoes
{
    public class ExcecoesComuns
    {

        public ExcecoesComuns()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exceções em tempo de execução do .NET Framework\n");

            Formatatabela("ArithmeticException", "Classe base para outras exceções que ocorrem durante operações aritmética");
            Formatatabela("ArrayTypeMismatchException", "Lançado quando é tentado armazenar um elemento incompatível dentro de um array");
            Formatatabela("DivideByZeroException", "Ocorre quando o divisor é o número 0");
            Formatatabela("DivideByZeroException", "Lançado quando o índice informado no array é menor que zero ou maior que o tamanho do array");
            Formatatabela("InvalidCastException", "Ocorre quando é tentado converter um elemento para um tipo incompatível");
            Formatatabela("NullReferenceException", "Lançado quando é referenciado um elemento nulo");
            Formatatabela("OutOfMemoryException", "Ocorre quando a ocorre falha na criação de um novo objeto pois o CLR não tem espaço em memória suficiente");
            Formatatabela("OverﬂowException", "Lançado quando é gerada uma operação aritmética, projeção ou de conversão em um contexto verificado resulta em um estouro");
            Formatatabela("StackOverﬂowException", "Ocorre quando a execução da pilha está cheia. Pode ocorrer em loops infinitos");
            Formatatabela("TypeInitializationException", "Lançado quando um construtor static lança uma exceção quandox não pode ser herdada");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nExceções pupulares do .NET Framework\n");

            Formatatabela("Exception", "Classe base de todas as exceções. Deve ser evitada pois é muito genérica");
            Formatatabela("ArgumentException", "Ocorre quando um argumento é inválido");
            Formatatabela("ArgumentNullException", "Uma especialização do ArgumentException que é lançada quando um dos argumentos é nulo e não permitido");
            Formatatabela("ArgumentOutOfRangeException", "Uma especialização do ArgumentException que é lançada quando os argumentos ultrapassam o intervalo de valores");
            Formatatabela("FormatException", "Lançado quando o argumento tem um formato inválido");
            Formatatabela("InvalidOperationException", "Lançado quando uma chamada de método é inválida para o estado atual do objeto");
            Formatatabela("NotImplementedException", "Ocorre quando um código gerado não foi implementado ainda");
            Formatatabela("NotSupportedException", "Lançado quando um método invocado não é suportado");
            Formatatabela("ObjectDisposedException", "Ocorre quando uma operação é executada em um objeto descartado");

        }

        private void Formatatabela(string nome, string descricao)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", nome);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}.", descricao);
        }

    }
}
