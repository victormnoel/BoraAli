namespace BoraAli.Api.Models
{
    public class Favoritos : Base
    {
        public int QtdFavoritos { get; set; }
        public PontoTuristico PontoTuristico { get; set; }
        public Usuario Usuario { get; set; }  

        public Favoritos(PontoTuristico pontoTuristico, Usuario usuario)
        {
            PontoTuristico = pontoTuristico;
            Usuario = usuario;
        }
    }
}
