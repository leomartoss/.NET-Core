using System;
using System.Globalization;

namespace PessoaMaisVelha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Informe o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da primeira pessoa: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da primeira pessoa: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if(pessoa1.idade > pessoa2.idade)            
                Console.WriteLine($"{pessoa1.nome} é mais velho(a) que {pessoa2.nome}");
            else
                Console.WriteLine($"{pessoa2.nome} é mais velho(a) que {pessoa1.nome}");
        }
    }
}