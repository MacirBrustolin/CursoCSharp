using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Capítulo 3 - Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadorAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },

                //Capítulo 4 - Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar },
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura IF/ELSE IF - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura SWITCH - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura WHILE - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura DO WHILE - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura FOR - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura FOR/EACH - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando o BREAK - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando o CONTINUE - Estruturas de Controle", UsandoContinue.Executar },
                
                //Capítulo 5 - Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Acessar Atributos - Classes e Métodos", DesafioAcessarAtributo.Executar },
                {"Params - Classes e Métodos", Params.Executar },
                {"Parametros Nomeados - Classes e Métodos", Params.Executar },
                {"GET/SET - Classes e Métodos", GetSet.Executar },
                {"PROPS - Classes e Métodos", Props.Executar },
                {"Read Only - Classes e Métodos", Readonly.Executar },
                {"ENUM - Classes e Métodos", ExemploEnum.Executar },
                {"STRUCT - Classes e Métodos", ExemploStruct.Executar },
                {"STRUCT vs CLASSE - Classes e Métodos", StructVsClasse.Executar },
                {"VALOR vs RFERÊNCIA - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parâmetros pro Referencias - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parâmetros com valor Padrão - Classes e Métodos", ParametroPadrao.Executar },

                //Capítulo 6 - Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"ArrayList - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },

                //Capítulo 7 - Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar },
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar },
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar },
                {"Abstract - Orientação a Objetos", OO.Abstract.Executar },
                {"Interface - Orientação a Objetos", OO.Interface.Executar },
                {"SEALED - Orientação a Objetos", OO.Sealed.Executar },

                //Capítulo 8 - Métodos e Funções
                {"Exemplo LAMBDA - Métodos e Funções", ExemploLambda.Executar },
                {"LAMBDAs como Delegates- Métodos e Funções", LambdasDelegate.Executar },
                {"Usando Delegates- Métodos e Funções", UsandoDelegate.Executar },
                {"Delegate como Função Anônima- Métodos e Funções", DelegateFuncAnonima.Executar },
                {"Delegate como Parâmetros- Métodos e Funções", DelegatesComoParametros.Executar },
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar },

                //Capítulo 9 - Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },

                //Capítulo 10 - Usando API
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar },
                {"Lendo Arquivos - Usando API", LendoArquivos.Executar },
                {"Exemplo File Info - Usando API", ExemploFileInfo.Executar },
                {"Diretórios - Usando API", Diretorios.Executar },
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar },
                {"Exemplo Path - Usando API", ExemploPath.Executar },
                {"Exemplo Date Time - Usando API", ExemploDateTime.Executar },
                {"Exemplo Time Span - Usando API", ExemploTimeSpan.Executar },

                //Capítulo 11 - Tópicos Avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar },
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}