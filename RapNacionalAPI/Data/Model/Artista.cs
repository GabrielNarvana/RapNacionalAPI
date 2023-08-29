namespace RapNacionalAPI.Data.Model
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Album> Albuns { get; set; }
        public List<Musica> Singles { get; set; }

        public DateTime DataCriacao { get; set; }

    }
}
