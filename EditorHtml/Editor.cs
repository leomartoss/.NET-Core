using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            Start();
        }

        public static void Start()
        {

            var file = new StringBuilder(); //construtor de texto

            do // adicione uma nova linha enquanto o usuário não teclar ESC
            {
                file.Append(Console.ReadLine()); // Append é a forma de anexar um item.
                file.Append(Environment.NewLine); // Obtém a cadeia de caracteres de nova linha definida para esse ambiente.
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------");
            Console.WriteLine(" Deseja salvar o arquivo? S/N");
            Viewer.Show(file.ToString());
        }
    }
}