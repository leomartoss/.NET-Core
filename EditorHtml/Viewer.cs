using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("------------");
            Replace(text);
            Console.WriteLine("------------");
            Console.ReadKey();
            Menu.Show();
        }
        public static void Replace(string text)
        {
            //Regex = basicamente uma string que substitui outra string
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>"); // aqui ele vai pegar tudo que estiver entre os strongs.
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i])) //IsMatch = Essa palavra é igual a "palavra"?
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (
                                    words[i].LastIndexOf('<') - 1) 
                                    - words[i].IndexOf('>')
                                )
                        )
                    );
                    Console.Write(" ");
                } else{
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
