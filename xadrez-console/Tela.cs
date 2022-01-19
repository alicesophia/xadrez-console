using System;
using xadrez_console.Entities.tabuleiro;
using xadrez_console.Entities.tabuleiro.enums;
using xadrez_console.Entities.xadrez;

namespace xadrez_console {
    class Tela {

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro) {
            
            for (int i = 0; i < tabuleiro.Linhas; i++) {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.Colunas; j++) {
                    if (tabuleiro.Peca(i, j) == null) {
                        Console.Write("- ");
                    } else {
                        ImprimirPeca(tabuleiro.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }            
            Console.WriteLine("  a b c d e f g h");
        }

        public static PosicaoXadrez LerPosicaoXadrez() {
            string entrada = Console.ReadLine();
            char coluna = entrada[0];
            int linha = int.Parse(entrada[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca) {
            if (peca.Cor == Cor.Branca) {
                Console.Write(peca);
            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
