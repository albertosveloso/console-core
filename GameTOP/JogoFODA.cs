using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        public readonly iJogador _jogadorA;
        public readonly iJogador _jogadorB;
        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());

            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
        }
    }
}