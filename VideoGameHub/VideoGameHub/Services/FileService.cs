namespace VideoGameHub.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _env;

        public FileService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public string? GuardarImagen(IFormFile? archivo)
        {
            if (archivo == null) return null;

            var nombre = Guid.NewGuid() +
                Path.GetExtension(archivo.FileName);

            var ruta = Path.Combine(
                _env.WebRootPath,
                "images",
                "videojuegos"
            );

            if (!Directory.Exists(ruta))
                Directory.CreateDirectory(ruta);

            var rutaCompleta =
                Path.Combine(ruta, nombre);

            using var stream =
                new FileStream(rutaCompleta, FileMode.Create);

            archivo.CopyTo(stream);

            return "/images/videojuegos/" + nombre;
        }
    }
}