using Tabuleiro;

namespace XadrezConsole.Tabuleiro
{
    class Tab
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] Pecas;

        public Tab(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            this.Pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return this.Pecas[linha, coluna];
        }
    }
}
