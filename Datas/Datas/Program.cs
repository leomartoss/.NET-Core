using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var data = new DateTime(); // Nessa instância apenas criamos uma data padrão do sistema.
            //var data = new DateTime(2022, 10, 12, 8, 20, 30); // DateTime com ano, mes, dia, hora, minuto, segundos.
            //var data = DateTime.Now.ToString("yyyy/MM/dd"); ; // Para criarmos a data atual, é preciso utilizarmos o DateTime.Now

            /*Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);

            Console.WriteLine((int)data.DayOfWeek); // Como o DayOfWeek é um enum, podemos realizar a conversão para inteiro.
            Console.WriteLine(data.DayOfYear);*/

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.Clear();
            //var data = DateTime.Now;

            //var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data); 
            //var formatada = String.Format("{0:r}", data); // Colocando o r ele já nos dá um padrão que muitos sistemas já utilizam.
            //var formatada = String.Format("{0:s}", data); // O s é muito utilizado em bancos nosql - como o Mongo DB
            //var formatada = String.Format("{0:u}", data); // O u é o formato universal e é muito utilizado em arquivos json

            //Sempre que precisar adicionar algo à sua data:
            /*
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));

            -- Para trazer uma data nula:
            DateTime? data = null;
            Console.WriteLine(data);
            */

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.Clear();

            //// Convertendo idiomas
            //var pt = new CultureInfo("pt-PT");
            //var br = new CultureInfo("pt-BR");
            //var en = new CultureInfo("en-US");
            //var de = new CultureInfo("de-DE");
            //var atual = CultureInfo.CurrentCulture; //ativando a cultura atual da máquina - de acordo com o servidor
            //Console.WriteLine(DateTime.Now.ToString("D", atual)); //exibindo na tela

            //var utcDate = DateTime.UtcNow; // pega a data UNIVERSAL

            //Console.WriteLine(utcDate.ToLocalTime());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ///*//Timezone
            //var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            //Console.WriteLine(timezoneAustralia);

            //var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia); //Pegando a data da Austrália
            //Console.WriteLine(horaAustralia);

            ////aqui ele irá listar todas as timezones
            //var timezones = TimeZoneInfo.GetSystemTimeZones();
            //foreach(var timezone in timezones)
            //{
            //    Console.WriteLine(timezone.Id);
            //    Console.WriteLine(timezone);
            //    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            //    Console.WriteLine("----------");*/
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Timespan:
            //Console.Clear();

            //var timeSpan = new TimeSpan();
            //Console.WriteLine(timeSpan);

            //var timeSpanNanosegundos = new TimeSpan(1);
            //Console.WriteLine(timeSpanNanosegundos);

            //var timeSpanHoraMinutoSegundo = new TimeSpan(5,12,8);
            //Console.WriteLine(timeSpanHoraMinutoSegundo);

            //var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            //Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            //var timeSpanDiaHoraMinutoSegundoMilisegundo = new TimeSpan(3, 5, 50, 10, 20);
            //Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilisegundo);

            //Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            //Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            //Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            ////Quantos dias tem o mês:
            
            Console.Clear();
            Console.WriteLine(DateTime.DaysInMonth(2022, 9)); // Essa fuñção traz a quantidade de dias que o mês possui, dado o ano atual.
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // Essa função trará um bolean(true or false) para sabermos se é horário de verão ou não.

            // A Função IsWeekend diz se é fim de semana ou não
            static bool IsWeekend(DayOfWeek today)
            {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }

        }
    }
}