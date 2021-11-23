﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.Write("Insira seu Palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Número encontrado em {0} tentativas!!", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor...Tente Novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                } else {
                    Console.WriteLine("Maior...Tente Novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                }

            }
            if (tentativasRestantes == 0) {
                Console.WriteLine("\nTentativas Esgotadas!! :(");
            }
        }
    }
}
