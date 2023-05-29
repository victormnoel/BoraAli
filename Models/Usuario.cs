namespace BoraAli.Api.Models
{
    public class Usuario : Base
    {
      
        public string Nome { get; set; } = string.Empty;
        public string Email{ get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Genero { get; set; } = string.Empty;


    }
}
