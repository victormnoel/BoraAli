namespace BoraAli.Api.Models
{
    public class Visita : Base
    {
        public int Idade { get; set; }
        public string Nome {get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;

    }
}
