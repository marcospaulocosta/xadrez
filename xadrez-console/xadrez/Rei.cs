using System;
using tabuleiro;

namespace xadrez
{
    // Classe Torre herdando de peça
    class Rei : Peca
    {
        //referencia a super classe
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        //sobrescrevendo o método ToString()
        public override string ToString()
        {
            return "R";
        }

    }
}
