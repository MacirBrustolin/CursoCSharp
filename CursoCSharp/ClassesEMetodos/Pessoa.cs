using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        public string Nome; //string tem valor padrão null.
        public int Idade;   //int tem valor padrão 0.

        public string Apresentar() {
            if (Nome.Length > 0 && Idade > 0) {
                return string.Format($"Olá, me chamo {Nome} e tenho {Idade} anos.");
            } else if (Nome.Length == 0) {
                if (Idade == 0) {
                    return string.Format($"Insira o Nome e a Idade corretamente.");
                }
                return string.Format($"Insira o Nome corretamente.");
            } else {
                return string.Format($"Insira a Idade corretamente.");
            }
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
