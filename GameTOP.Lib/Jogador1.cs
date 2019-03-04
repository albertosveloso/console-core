using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        public string Chuta()
        {
            return $"{_Nome} esta chutando \n";
        }

        public string Corre()
        {
            return $"{_Nome} esta correndo \n";
        }

        public string Passe()
        {
            return $"{_Nome} esta passando";
        }
        
    }
}