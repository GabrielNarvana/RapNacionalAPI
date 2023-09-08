using RapNacionalAPI.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RapNacionalAPI.DTOs.Response
{
    public class AlbumResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Lancamento { get; set; }
        public string Duracao { get; set; }
        public string? Gravadora { get; set; }
        public string? Capa { get; set; }
        public List<Musica>? Faixas { get; set; }
        public int? ArtistaId { get; set; }
        public Artista? Artista { get; set; }
    }
}
