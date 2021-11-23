using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class AmigoProximo {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Próximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegradoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }

    }
}
