using Microsoft.AspNetCore.Mvc;
using VideoGameHub.Models;
using VideoGameHub.Services;

namespace VideoGameHub.Controllers
{
    public class VideojuegoController : Controller
    {
        private readonly IVideojuegoService _service;
        private readonly IDesarrolladorService _devService;
        private readonly IFileService _fileService;

        public VideojuegoController(
            IVideojuegoService service,
            IDesarrolladorService devService,
            IFileService fileService)
        {
            _service = service;
            _devService = devService;
            _fileService = fileService;
        }

        public IActionResult Index()
            => View(_service.GetAll());

        public IActionResult Create()
        {
            var vm = new VideojuegoViewModel
            {
                Desarrolladores =
                    _devService.GetAll()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(VideojuegoViewModel vm)
        {
            var juego = new Videojuego
            {
                Titulo = vm.Titulo,
                Genero = vm.Genero,
                Plataforma = vm.Plataforma,
                Precio = vm.Precio,
                DesarrolladorId = vm.DesarrolladorId,
                ImagenUrl =
                    _fileService.GuardarImagen(vm.Imagen)
            };

            _service.Crear(juego);

            return RedirectToAction("Index");
        }
    }
}