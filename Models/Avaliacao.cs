namespace BoraAli.Api.Models
{
    public class Avaliacao : Base
    {
        public int Nota { get; set; }
        public string? Comentario { get; set; }
        public int UsuarioId { get; set; }
        public int PontoTuristicoId { get; set; }

    }
}
