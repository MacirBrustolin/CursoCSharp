using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {

        //Todos
        public string InfoPublica = "Tenho um Instagram.";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (assembly)
        internal ulong NumeroCelular = 554599999999;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias.";

        //mesma classe ou herança no mesmo projeto (C# => 7.2)
        private protected string SegradoFamilia = "Bla Bla.";

        //private é o padrão
        bool UsaMuitoPhotoshop = false;

        public void MeusAcessos() {
            Console.WriteLine("Sub Celebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegradoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);


        }

    }
}
