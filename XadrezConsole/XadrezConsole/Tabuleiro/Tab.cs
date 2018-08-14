using Tabuleiro;

namespace XadrezConsole.Tabuleiro
{
    class Tab
    {
        private int Linhas { get; set; }
        private int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tab(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            this.Pecas = new Peca[linhas, colunas];
        }
    }
}
