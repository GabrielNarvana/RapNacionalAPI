using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapNacionalAPI.Data.Model
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime Lancamento { get; set; }
        public TimeSpan? Duracao { get; set; } = TimeSpan.Zero;

        [MaxLength(100)]
        public string? Gravadora { get; set; } = null;

        [MaxLength(1000)]
        public string? Capa { get; set; } = null;

        [Required]
        public DateTime DataCriacao {  get; set; }

        public List<Musica>? Faixas { get; set; }

        [ForeignKey("Artista")]
        public int? ArtistaId { get; set; } = null;
        public Artista? Artista { get; set; } = null;

    }
}
