using xadrez_console.Entities.tabuleiro.enums;

namespace xadrez_console.Entities.tabuleiro {
    abstract class Peca {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            this.Posicao = null;
            this.Tabuleiro = tabuleiro;
            this.Cor = cor;
            this.QtdMovimentos = 0;
        }

        public void IncrementarQtdMovimentos() {
            QtdMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();

    }
}
