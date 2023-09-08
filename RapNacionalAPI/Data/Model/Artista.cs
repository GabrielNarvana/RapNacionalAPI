using RapNacionalAPI.Data.Model.Common;
using System.ComponentModel.DataAnnotations;

namespace RapNacionalAPI.Data.Model
{
    public class Artista : BaseEntity
    {

        [MaxLength(150)]
        [Required]
        public string Nome { get; set; }

        [MaxLength(1000)]
        public string? Foto { get; set; } = null;
        public List<Album>? Albuns { get; set; } = null;
        public List<Musica>? Singles { get; set; } = null;

    }
}
