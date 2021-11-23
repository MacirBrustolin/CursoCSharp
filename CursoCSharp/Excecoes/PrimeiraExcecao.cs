using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {
    public class Conta {
        double Saldo;
        public Conta(double saldo) {
            Saldo = saldo;
        }
        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo Insufucuente.");
            }
            Saldo -= valor;
        }
    }
    class PrimeiraExcecao {
        public static void Executar() {
            var conta = new Conta(1_223.45);

            try {
                conta.Sacar(1_600.0);
                Console.WriteLine("Retirada Com Sucesso!");
            } catch (Exception ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Obrigado!");
            }

        }
    }
}
