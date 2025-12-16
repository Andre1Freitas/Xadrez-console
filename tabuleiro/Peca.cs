using Xadrez_console.tabuleiro;

namespace Xadrez_console.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null!;
            Cor = cor;
            Tab = tab;
            QtdeMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            QtdeMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}

