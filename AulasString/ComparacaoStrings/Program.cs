using System;
using System.IO;
using System.Globalization;

namespace ComparacaoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
        //vai comparar todo o texto
        //Console.WriteLine(texto.CompareTo("Testando"));
        /*
        Console.WriteLine(texto.Contains("test"));
        //vai comparar se no teste há a palavra teste
        Console.WriteLine(texto.Contains("Test")); 
        //vai comparar se no teste há a palavra Teste com o T maiúsculo
        Console.WriteLine(texto.Contains("Test", StringComparison.OrdinalIgnoreCase)); 
        //Nesse caso ele fará a comparação ignorando o case sensitive.
        Console.WriteLine(texto.Contains(null));
        //aqui vai dar um erro de exception, pois é um valor que não foi atribuído a nulo.*/

        //Este texto começa com?:
        // Console.WriteLine(texto.StartsWith("Este"));
        // Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));//irá ignorar o case sensitive.
        // Console.WriteLine(texto.StartsWith("texto"));

        // // Este texto termina com?:
        // Console.WriteLine(texto.EndsWith("teste"));
        // Console.WriteLine(texto.EndsWith("este", StringComparison.OrdinalIgnoreCase));
        // Console.WriteLine(texto.EndsWith("xpro"));

        //No caso abaixo, o texto deve ser exatamente igual.
        // var texto = "Este texto é um teste";
        // Console.WriteLine(texto.Equals("Este texto é um teste"));
        // Console.WriteLine(texto.Equals("Este texto é um TESTE", StringComparison.OrdinalIgnoreCase));
        // Console.WriteLine(texto.Equals("Este texto é um xpro")); 

        //Posição de array de cada caracter informado/desejado.
        // var texto = "Este texto é um teste";
        // Console.WriteLine(texto.IndexOf("é"));
        // Console.WriteLine(texto.LastIndexOf("t"));

        //Convertendo texto para minúsculo/maiúsculo.
        //Adicionando texto e removendo texto através do número index.
        //Contagem de caracteres
        // var texto = "Este texto é um teste";
        // Console.WriteLine(texto.ToLower());
        // Console.WriteLine(texto.ToUpper());
        // Console.WriteLine(texto.Insert(5, "AQUI")); //Vai adicionar o texto na posição desejada.
        // Console.WriteLine(texto.Remove(5, 5)); //Vai remover o caracter da 5 posição e os próximos 5 caracteres
        // Console.WriteLine(texto.Length); //Realiza a contagem de caracteres

        //Trocando textos
        //var texto = "Este texto é um teste";
        // Console.WriteLine(texto.Replace("Este", "isto")); //Trocar este por isto.
        // Console.WriteLine(texto.Replace("e", "X")); //Trocar em todo o texto a letra e por x
        // Console.WriteLine(texto.Replace("asdasdasd", "X")); //não substituirá nada, pois não existe no texto.

        // var divisao = texto.Split(" "); //Sempre que houver um espaço, ocorrerá uma quebra de linha.
        // Console.WriteLine(divisao[0]);
        // Console.WriteLine(divisao[1]);
        // Console.WriteLine(divisao[2]);
        // Console.WriteLine(divisao[3]);

        var texto = " Este texto é um teste ";
        var resultado = texto.Substring(5, 5);
        Console.WriteLine(texto);
        Console.WriteLine(texto.Trim());

        Console.ReadKey();
        }
    }
}