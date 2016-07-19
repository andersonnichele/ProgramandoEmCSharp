using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Multithreading_and_asynchronous_processing.Exemplos.UtilizandoAsyncEAwait
{
    public class AsyncAwait
    {

        public AsyncAwait()
        {
            string result = DownloadContent().Result;

            Console.WriteLine(result);

            Console.ReadKey();
        }

        /*O async indica que o método é assíncrono */
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                /*await executa um método que é executado de forma assíncrona*/
                string result = await client.GetStringAsync("http://www.microsoft.com");

                return result;
            }
        }
    }
}
