using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Props {
        public class CarroOpcional {
            double desconto = 0.1;

            string nome;
            public string Nome {
                get {
                    return "Opcional: " + nome;
                }
                set {
                    nome = value;
                }

            }
            //Propriedades Autoimplementadas
            public double Preco { get; set; }

            //Somente Leitura
            public double PrecoComDesconto {
                get => Preco - (desconto * Preco);  //Lambda

                //get {
                //    return Preco - (desconto * Preco);
                //}
            }
            public CarroOpcional() {

            }

            public CarroOpcional(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar() {
            var op1 = new CarroOpcional("ArCondicionado", 3499.90);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;
            
            Console.WriteLine(op1.Nome + " => R$" + op1.Preco + ". (Preço com Desconto (10%) = R$" + op1.PrecoComDesconto + ").");
            Console.WriteLine(op2.Nome + " => R$" + op2.Preco + ". (Preço com Desconto (10%) = R$" + op2.PrecoComDesconto + ").");
        }
    }
}
