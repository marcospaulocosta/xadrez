using tabuleiro;

namespace xadrez
{
    // Classe Torre herdando de peça
    class Torre : Peca
    {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        //sobrescrevendo o método ToString()
        public override string ToString()
        {
            return "T";
        }

    }
}
