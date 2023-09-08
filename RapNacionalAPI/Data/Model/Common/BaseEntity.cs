using System.ComponentModel.DataAnnotations;

namespace RapNacionalAPI.Data.Model.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaModificacao { get; set; } = DateTime.Now;
    }
}
