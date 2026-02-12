using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameHub.Models
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }

        public string TextoComentario { get; set; }

        [Range(1, 5)]
        public int Valoracion { get; set; }

        public DateTime Fecha { get; set; }

        [ForeignKey("Videojuego")]
        public int VideojuegoId { get; set; }
        public Videojuego Videojuego { get; set; }
    }
}
