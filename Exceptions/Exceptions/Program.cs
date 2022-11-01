using System;
using System.Globalization;

namespace Exceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            var arr = new int[3];

            //Sempre fazer do mais específico para o mais genérico

            try
            {
                for (var index = 0; index < 10; index++)
                {
                    // IndexOutOfRangeException
                    Console.WriteLine(arr[index]);
                }

                Cadastrar("");
            }
            catch(IndexOutOfRangeException ex) // Se ocorrer o erro IndexOutOfRangeException, passe dentro deste catch e retorne a seguinte mensagem.
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista.");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto.");
            }
            catch (MinhaException ex) // Caso ocorra qualquer outro erro, passe dentro deste e retorne a seguinte mensagem.
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Execução customizada.");
            }
            catch (Exception ex) // Caso ocorra qualquer outro erro, passe dentro deste e retorne a seguinte mensagem.
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Algo deu errado.");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }

            static void Cadastrar(string texto)
            {
                if (string.IsNullOrEmpty(texto))
                {
                    throw new MinhaException(DateTime.Now);
                }
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}