using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }
        public Comida() {}
    }
    public class Feijao : Comida {
        public Feijao(double peso) : base(peso) { }
    }
    public class Arroz : Comida {
        
    }
    public class Carne : Comida {
         
    }
    public class Pessoa {
        public double Peso;
        //public void Comer(Feijao feijao) {
        //    Peso += feijao.Peso;
        //}
        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}
        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}
        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }
    class Polimorfismo {
        public static void Executar() {
            Feijao Ingrediente1 = new Feijao(0.3);
            //Ingrediente1.Peso = 0.3;

            Arroz Ingrediente2 = new Arroz();
            Ingrediente2.Peso = 0.25;

            Carne Ingrediente3 = new Carne();
            Ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(Ingrediente1);
            cliente.Comer(Ingrediente2);
            cliente.Comer(Ingrediente3);

            Console.WriteLine($"O peso do cliente agora é {cliente.Peso}Kg.");
        }
    }
}
