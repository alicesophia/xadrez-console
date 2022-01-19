﻿using xadrez_console.Entities.tabuleiro.enums;

namespace xadrez_console.Entities.tabuleiro {
    class Peca {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QtdMovimentos = 0;
        }

        public void IncrementarMovimentos() {
            QtdMovimentos++;
        }
    }
}
