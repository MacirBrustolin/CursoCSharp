using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAcessarAtributo {

        int a = 10; // não pode mexer.


        public static void Executar() {
            //Acessar a variável 'a' dentro do método executar.

            //Console.WriteLine(a);

            DesafioAcessarAtributo desafio = new DesafioAcessarAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
