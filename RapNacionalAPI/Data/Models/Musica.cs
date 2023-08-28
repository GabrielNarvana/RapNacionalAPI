﻿namespace RapNacionalAPI.Data.Models
{
    public class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public Album? Album { get; set; }
    }
}
