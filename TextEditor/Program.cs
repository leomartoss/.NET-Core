using System;
using System.IO;
using System.Globalization;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Olá! Poderia informar a opção desejada?");
            Console.WriteLine("\n| 1 | Abrir arquivo      |");
            Console.WriteLine("| 2 | Criar novo arquivo |");
            Console.WriteLine("| 0 | Sair               |");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir(){
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path)) //StreamReader = lê o arquivo.
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            
            Console.WriteLine(" ");
            Console.ReadLine();

            Menu();
        }

        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC PARA SAIR)");
            Console.WriteLine (" ");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine; //utilizando para quebra de linha
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape); 

            Salvar(text);     
        }

        static void Salvar(string text){
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine(); //path = diretório do arquivo criado.

            using(var file = new StreamWriter(path)) //Stream Writer = escrever um arquivo.
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }

    }    
}