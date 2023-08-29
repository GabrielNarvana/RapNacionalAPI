﻿namespace RapNacionalAPI.Data.Model
{
    public class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public Album? Album { get; set; }
        public string? Gravadora { get; set; }
        public string? Capa { get; set; }
        public DateTime DataCriacao { get; set; }

    }
}