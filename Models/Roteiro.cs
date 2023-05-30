namespace BoraAli.Api.Models
{
    public class Roteiro : Base
    {
        public string Nome { get; set; } = string.Empty;
        public double TamanhoRota { get; private set; }
        public int QtdPontosVisitados { get; private set; }
        public Usuario Usuario { get; private set; }
        public Avaliacao Avaliacao { get; set; } = new Avaliacao();
        public List<PontoTuristico> PontoTuristico { get; set; }

        public Roteiro(int qtdPontosVisitados, double tamanhoRota, Usuario usuario, List<PontoTuristico> pontoTuristicos)
        {
            QtdPontosVisitados = qtdPontosVisitados;
            Usuario = usuario;
            TamanhoRota = tamanhoRota;
            PontoTuristico = pontoTuristicos;
        }
    }
}
