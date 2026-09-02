namespace BlazorApp2.Models
{
    public class Pelicula
    {

        public string Titulo { get; set; } = null!;

        public string Genero { get; set; } = null!;

        public int Anio { get; set; }

        public string? ImagenUrl { get; set; }

    }
}
