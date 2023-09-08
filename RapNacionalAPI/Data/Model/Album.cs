using RapNacionalAPI.Data.Model.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapNacionalAPI.Data.Model
{
    public class Album : BaseEntity
    {

        [MaxLength(150)]
        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime Lancamento { get; set; }
        public string Duracao { get; set; } = "00:00";

        [MaxLength(100)]
        public string? Gravadora { get; set; } = null;

        [MaxLength(1000)]
        public string? Capa { get; set; } = null;

        public List<Musica>? Faixas { get; set; }

        [ForeignKey("Artista")]
        public int? ArtistaId { get; set; } = null;
        public Artista? Artista { get; set; } = null;

    }
}
