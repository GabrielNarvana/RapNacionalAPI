namespace RapNacionalAPI.Data.Models
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Album>? Albuns { get; set; }
    }
}
