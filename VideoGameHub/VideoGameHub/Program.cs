using Microsoft.EntityFrameworkCore;
using VideoGameHub.Data;
using VideoGameHub.Repositories;
using VideoGameHub.Services;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(
            builder.Configuration.GetConnectionString("DefaultConnection")
        )
    )
);



builder.Services.AddScoped<IVideojuegoRepository, VideojuegoRepository>();
builder.Services.AddScoped<IComentarioRepository, ComentarioRepository>();
builder.Services.AddScoped<IDesarrolladorRepository, DesarrolladorRepository>();



builder.Services.AddScoped<IVideojuegoService, VideojuegoService>();
builder.Services.AddScoped<IComentarioService, ComentarioService>();
builder.Services.AddScoped<IDesarrolladorService, DesarrolladorService>();

// File Service (para subir imágenes)
builder.Services.AddScoped<IFileService, FileService>();



builder.Services.AddControllersWithViews();



var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
