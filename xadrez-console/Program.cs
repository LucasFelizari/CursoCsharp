using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 6));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 5));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 4));

                Tela.imprimirTabuleiro(tab);


            }
            catch (TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }
        }   
    }
}

