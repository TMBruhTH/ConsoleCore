using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;    

        public Jogador1(string Nome = "Ronaldo")
        {
            _Nome = Nome;
        }
        public string Chutar()
        {
          return  $"{_Nome} está chutando \n";
        }    

        public string Corre()
        {
           return $"{_Nome} está correndo \n";
        }

        public string Passe()
        {
           return $"{_Nome} está passando";
        }
    }
}