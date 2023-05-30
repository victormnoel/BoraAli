﻿namespace BoraAli.Api.Models
{
    public class Visita : Base
    {
        public DateTime DataVisita { get; private set; }
        public Usuario Usuario { get; set; }
        public PontoTuristico PontoTuristico { get; set; }

        public Visita(Usuario usuario, PontoTuristico pontoTuristico)
        {
            PontoTuristico = pontoTuristico;
            Usuario = usuario;
        }
    }
}
