using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {

            //int i = 1;
            //while (i <= 10) {
            //    Console.WriteLine($"O valor de i é {i}.");
            //    i++;
            //}

            //var corAnterior = Console.BackgroundColor;
            //var fonteAnterior = Console.ForegroundColor;
            //for (int i = 1; i <= 10; i++){

            //    Console.BackgroundColor = ConsoleColor.Cyan;
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write($"O valor de i é {i}.");
            //    Console.BackgroundColor = corAnterior;
            //    Console.ForegroundColor = fonteAnterior;
            //    Console.Write("\n");
            //}
            //Console.WriteLine("Fim!!");

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamaho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i=1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("A média da turma é: {0}", media);
        }
    }
}
