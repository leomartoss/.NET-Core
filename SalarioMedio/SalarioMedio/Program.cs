using System;
using System.Globalization;

namespace SalarioMedio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            mediaSalarial();
        }        

        static void mediaSalarial()
        {
            Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Informe o nome do primeiro funcionário: ");
            funcionario1.nome = Console.ReadLine();

            Console.WriteLine("Informe o salário do primeiro funcionário: ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nInforme o nome do segundo funcionário: ");
            funcionario2.nome = Console.ReadLine();

            Console.WriteLine("Informe o salário do segundo funcionário: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var mediaSalarial = (funcionario2.salario + funcionario1.salario) / 2;

            Console.WriteLine($"\nA média salarial destes funcionários é: {mediaSalarial}");

        }
    }
}