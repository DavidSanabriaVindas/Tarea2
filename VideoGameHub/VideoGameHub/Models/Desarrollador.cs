using System.ComponentModel.DataAnnotations;

namespace VideoGameHub.Models
{
    public class Desarrollador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Pais { get; set; }

        public List<Videojuego> Videojuegos { get; set; }
    }
}
