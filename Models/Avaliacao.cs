namespace BoraAli.Api.Models
{
    public class Avaliacao : Base
    {
        public int Nota { get; set; }
        public string? Comentario { get; set; }
        public Usuario usuario { get; set; }
        public PontoTuristico PontoTuristico { get; set; }


    }
}
