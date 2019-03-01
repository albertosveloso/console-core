using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador("Beto"));
            jogo.IniciarJogo();
        }
    }

    public class Jogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }
        public void Chuta()
        {
            Console.Write($"{_Nome} esta chutando");
        }

        public void Corre()
        {
            Console.Write($"{_Nome} esta correndo");
        }

        public void Passe()
        {
            Console.Write($"{_Nome} esta passando");
        }
        
    }
}
