namespace GameTop.Interface
{
    public class Jogador1 : iJogador{
        public readonly string Nome;

        public Jogador1(string nome = "Matheus"){
            this.Nome = nome;
        }
            
        public string Chutar(){
            return $"{Nome} esta chutando\n"; 
        }

        public string Correr(){
            return $"{Nome} esta correndo\n"; 
        }

        public string Passar(){
            return $"{Nome} esta passando\n"; 
        }
    }
}