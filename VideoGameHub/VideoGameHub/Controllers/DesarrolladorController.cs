using Microsoft.AspNetCore.Mvc;
using VideoGameHub.Models;
using VideoGameHub.Services;

namespace VideoGameHub.Controllers
{
    public class DesarrolladorController : Controller
    {
        private readonly IDesarrolladorService _service;

        public DesarrolladorController(
            IDesarrolladorService service)
        {
            _service = service;
        }

        public IActionResult Index()
            => View(_service.GetAll());

        public IActionResult Create()
            => View();

        [HttpPost]
        public IActionResult Create(Desarrollador d)
        {
            _service.Crear(d);
            return RedirectToAction("Index");
        }
    }
}
