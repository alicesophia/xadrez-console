using xadrez_console.Entities.tabuleiro;
using xadrez_console.Entities.tabuleiro.enums;

namespace xadrez_console.Entities.xadrez {
    class Rei : Peca {

        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {
        }

        public override string ToString() {
            return "R";
        }
    }
}
