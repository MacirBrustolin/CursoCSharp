using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    class Abstract {
        //Uma classe abstrata não pode ser referenciada diretamente, somente se houver herança.
        public abstract class Celular {
            public abstract string Assistente();
            
            public string Tocar() {
                return ("Trim, trim, trim...");
            }

        }
        public class Samsumg : Celular {
            public override string Assistente() {
                return "Olá, meu nome é Bixby";
            }
        }
        public class Iphone : Celular {
            public override string Assistente() {
                return "Olá, meu nome é Siri.";
            }
        }
        public static void Executar() {
            var celulares = new List<Celular> {
                new Iphone(),
                new Samsumg()
            };
            foreach(var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }

        }
    }
}
