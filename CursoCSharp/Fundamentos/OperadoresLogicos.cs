using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // '&&' Operador E
            Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // '||' Operador OU
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // '^' OU exclusivo
            Console.WriteLine("Comprou TV 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); //'!' Operador de Negação

        }
    }
}
