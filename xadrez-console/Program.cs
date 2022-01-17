using System;
using xadrez_console.Entities.tabuleiro;
using xadrez_console.Entities.xadrez;
using xadrez_console.Entities.tabuleiro.enums;
using xadrez_console.Entities.tabuleiro.exception;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 0));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tabuleiro);

                Console.ReadLine();
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
