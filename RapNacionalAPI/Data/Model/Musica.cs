using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapNacionalAPI.Data.Model
{
    public class Musica
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Nome { get; set; }

        [Required]
        public TimeSpan Duracao { get; set; } = TimeSpan.Zero;

        [MaxLength(100)]
        public string? Gravadora { get; set; } = null;

        [MaxLength(1000)]
        public string? Capa { get; set; } = null;

        [Required]
        public DateTime DataCriacao { get; set; }

        [ForeignKey("Album")]
        public int? AlbumId { get; set; } = null;
        public Album? Album { get; set; } = null;

        [ForeignKey("Artista")]
        public int? ArtistaId { get; set; } = null;
        public Artista? Artista { get; set; } = null;

    }
}
