using Microsoft.AspNetCore.Mvc;
using VideoGameHub.Models;
using VideoGameHub.Services;

namespace VideoGameHub.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly IComentarioService _service;

        public ComentarioController(
            IComentarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(Comentario c)
        {
            c.Fecha = DateTime.Now;
            _service.Crear(c);

            return RedirectToAction(
                "Details",
                "Videojuego",
                new { id = c.VideojuegoId });
        }

        public IActionResult Delete(int id)
        {
            _service.Eliminar(id);
            return RedirectToAction("Index", "Videojuego");
        }
    }
}
