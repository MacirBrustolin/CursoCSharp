using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // se você coloca o indicador antes da variável, o incremento acontecerá antes da comparação, caso contrário, irá incrementar depois. Nesse caso o resultado é verdadeiro pq --numero2=2 e numero1=2.
            Console.WriteLine($"Número 1: {numero1}. \nNúmero 2: {numero2}.");
        }
    }
}
