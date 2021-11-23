using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            //Área da Circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo?" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short Salario = short.MaxValue;
            Console.WriteLine("Salário " + Salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            int maiorValorInt = int.MaxValue;
            Console.WriteLine("Menor valor Int: " + menorValorInt);
            Console.WriteLine("Maior valor Int: " + maiorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: "  +   populacaoBrasileira);

            long menorValorLong = long.MinValue;
            long maiorValorLong = long.MaxValue;
            Console.WriteLine("Menor Valor Long: "  + menorValorLong);
            Console.WriteLine("Maior Valor Long: "  + maiorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador: R$"  + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00; //Mais usados dos Reais!
            Console.WriteLine("Valor de Mercado da Apple: " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas: "  + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: "+letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);










        }
    }
}
