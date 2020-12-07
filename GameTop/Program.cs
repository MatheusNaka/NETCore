using System;
using GameTop.Interface;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoBom(
                new Jogador1(),
                new Jogador2()
                );
            jogo.IniciarJogo();
        }
    }
}
