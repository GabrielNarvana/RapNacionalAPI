﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Domain.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Lancamento { get; set; }
        public List<Musica> Faixas { get; set; }
        public TimeSpan Duracao { get; set; }
        public string Gravadora { get; set; }
        public string Capa { get; set; }
    }
}
