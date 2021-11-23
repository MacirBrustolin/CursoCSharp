using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua Idade? ");
            int idade = int.Parse(Console.ReadLine()); // "1" => 1

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O {nome} tem {idade} anos e R${salario} de salário.");

        }
    }
}
