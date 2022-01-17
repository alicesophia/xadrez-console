using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.Entities.tabuleiro;
using xadrez_console.Entities.tabuleiro.enums;

namespace xadrez_console.Entities.xadrez {
    class Torre : Peca {

        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {
        }

        public override string ToString() {
            return "T";
        }
    }
}
