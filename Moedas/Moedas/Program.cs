using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.21235m;

            Console.WriteLine(Math.Floor(valor));
            //A função Math.round() retorna o valor de um número arredondado para o inteiro mais proximo.
            //O Math.Ceiling sempre irá arredondar o valor para cima.
            //O Math.Floor sempre irá arredondar o valor para baixo.

            //Console.WriteLine(valor.ToString("F",CultureInfo.CreateSpecificCulture("pt-BR"))); 
            //O "C" irá converter o valor já em dinheiro, conforme especificado na linguagem escolhida
            //O "P" formata para porcentagem
            //O "N" irá formatar para o número
            //O "F" irá arredondar de acordo com a maior precisão
        }
    }
}