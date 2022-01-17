using System.Text;
using xadrez_console.Entities.tabuleiro;

namespace xadrez_console.Entities.xadrez {
    class PosicaoXadrez {

        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao() {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Coluna}{Linha}");
            return sb.ToString();
        }
    }
}
