using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameHub.Models
{
    public class Videojuego
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }
        public decimal Precio { get; set; }

        public string? ImagenUrl { get; set; }

        [ForeignKey("Desarrollador")]
        public int DesarrolladorId { get; set; }
        public Desarrollador Desarrollador { get; set; }

        public List<Comentario> Comentarios { get; set; }
    }
}