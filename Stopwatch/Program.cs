using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // ToLower = Passar para minúscula.
            char type = char.Parse(data.Substring(data.Length-1,1)); // Substring nos permite pegar uma parte da nossa cadeia de character.
            //data.Length irá trazer a quantidade de character que o user digitou.
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if(type == 'm'){
                multiplier = 60;
            } 
            if(time == 0){
                System.Environment.Exit(0);                
            }

            PreStart(time * multiplier);           

        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear(); // Limpa a tela
                currentTime++; // Adiciona um item --iteração
                Console.WriteLine(currentTime); // Printa o item na tela
                Thread.Sleep(1000); // O Thread faz o contador esperar um determinado intervalo. Neste caso 1000ms.
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
