using System;

namespace InterpolacaoString
{
    public class interString 
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            //var texto = "O preço do produto é: " + price + " apenas na promoção."; //não recomendável.
            //var texto = string.Format("O preço do produto é {0} apenas na promoção.", price);
            //var texto = $"O preço do produto é {price} apenas na promoção."; //maneira mais segura.
            var texto = $@"O preço do produto {price} é apenas uma promoção."; // o @ serve para quebrar linhas.

            Console.WriteLine(texto);

            Console.ReadLine();
        }
    }
}