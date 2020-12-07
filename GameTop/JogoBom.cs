using GameTop;

class jogoBom
{
    private readonly iJogador Jogador1;
    private readonly iJogador Jogador2;

    public jogoBom(iJogador jogador1, iJogador jogador2)
    {
        this.Jogador1 = jogador1;
        this.Jogador2 = jogador2;
    }

    public void IniciarJogo()
    {
        //System.Console.Write($"{Jogador.Nome} entrou no campo!!");
        System.Console.Write(Jogador1.Correr());
        System.Console.Write(Jogador1.Chutar());
        System.Console.Write(Jogador1.Passar());

        System.Console.Write("\nPróximo jogador \n");

        System.Console.Write(Jogador2.Correr());
        System.Console.Write(Jogador2.Chutar());
        System.Console.Write(Jogador2.Passar());
    }
}