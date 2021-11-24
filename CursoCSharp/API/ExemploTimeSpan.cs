using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API {
    class ExemploTimeSpan {
        public static void Executar() {
            var timeSpan = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(timeSpan);

            Console.WriteLine("Minutos do intervalo: " + timeSpan.Minutes);
            Console.WriteLine("Intervalo em minutos: " + timeSpan.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada; // tempo é do tipo Time Span
            Console.WriteLine("Duração: " + tempo);

            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timeSpan);

            Console.WriteLine("To String 1: " + timeSpan.ToString("g"));
            Console.WriteLine("To String 2: " + timeSpan.ToString("G"));
            Console.WriteLine("To String 3: " + timeSpan.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }
    }
}
