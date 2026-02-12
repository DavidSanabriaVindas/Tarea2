namespace VideoGameHub.Models
{
    public class VideojuegoViewModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }
        public decimal Precio { get; set; }

        public int DesarrolladorId { get; set; }

        // Archivo
        public IFormFile? Imagen { get; set; }

        public List<Desarrollador>? Desarrolladores { get; set; }
    }
}