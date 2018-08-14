using XadrezConsole.Tabuleiro;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tab Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tab tab)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.Tab = tab;
            this.QtdMovimentos = 0;
        }
    }
}
