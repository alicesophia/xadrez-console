using System;
using xadrez_console.Entities.tabuleiro;
using xadrez_console.Entities.xadrez;
using xadrez_console.Entities.tabuleiro.enums;
using xadrez_console.Entities.tabuleiro.exception;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('e', 4);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
        }
    }
}
