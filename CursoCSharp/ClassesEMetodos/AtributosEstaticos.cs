using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class AtributosEstaticos {
        public class Produto {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.1;

            public Produto(string nome, double preco, double desconto) {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
            }
            public Produto() {

            }

            public double calculaDesconto() {
                return Preco - Preco * Desconto;
            }

    }

    public static void Executar() {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            Produto.Desconto = 0.5;

            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
            };

            Console.WriteLine("Preço com desconto: {0}", produto1.calculaDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.calculaDesconto());

            Produto.Desconto = 0.05;

            Console.WriteLine("Preço com desconto: {0}", produto1.calculaDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.calculaDesconto());

        }
}
}
