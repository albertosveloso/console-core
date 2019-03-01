using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda("Anderson");
            jogo.IniciarJogo();
        }
    }

    class JogoFoda
    {
        public string _NomeJogador { get; }
        public JogoFoda(string nome)
        {
            _NomeJogador = nome;
        }
        public void IniciarJogo()
        {
            Console.WriteLine($"{_NomeJogador} chutou a bola");
        }
        
    }
}
