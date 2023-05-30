namespace BoraAli.Api.Models
{
    public class HorarioFunc : Base
    {
        public string DiaSemana{ get; set; } = string.Empty;
        public DateTime HorarioAbertura{ get; set; }
        public DateTime HorarioFechamento{ get; set; }
        public PontoTuristico PontoTuristico { get; set; } = new PontoTuristico();


    }
}
