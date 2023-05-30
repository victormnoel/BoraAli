namespace BoraAli.Api.Models
{
    public class Usuario : Base
    {
      
        public string Nome { get; private set; } = string.Empty;
        public string Email{ get; private set; } = string.Empty;
        public int Idade { get; private set; } 
        public string Genero { get; private set; } = string.Empty;
        public List<Visita> Visitas { get; set; } = new List<Visita>();
        public List<Favoritos> Favoritos { get; set; } = new List<Favoritos>();
        public Premio Premio { get; private set; } = new Premio();
        public List<Resgate> Resgates { get; private set; } = new List<Resgate>();


        public Usuario(string nome, string email, int idade, string genero)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
            Genero = genero;
        }
        public Usuario() { }
    }
}
