using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("A");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var itens in pilha) {
                Console.Write($"{itens} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); //Pega o valor do topo da lista (3.14 nesse caso) e remove da lista

            foreach (var itens in pilha) {
                Console.Write($"{itens} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); //Pega o valor do topo da lista (true), mas não o remove da lista.
        }
    }
}
