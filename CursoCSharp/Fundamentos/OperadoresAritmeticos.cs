using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            //Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é: {0}", totalDesconto );

            //IMC
            double peso = 65.0;
            double altura = 1.85;
            double IMC = peso / Math.Pow(altura, 2);
            Console.WriteLine($"o IMC é: {IMC}.");

            //Número par/ímpar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);



        }
    }
}
