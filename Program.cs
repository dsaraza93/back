// Program.cs
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Registrar controladores
builder.Services.AddControllers();

// Configurar EF Core InMemory
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("TasksDb"));

// Registrar la capa de servicio (opcional, si usas ITaskService)
builder.Services.AddScoped<ITaskService, TaskService>();

// Configurar CORS para permitir que Angular consuma esta API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// Middlewares
app.UseCors("AllowAll");
app.MapControllers();

app.Run();