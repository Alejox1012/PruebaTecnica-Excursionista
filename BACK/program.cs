var builder = WebApplication.CreateBuilder(args);

// 1. Agregar servicios necesarios
builder.Services.AddControllers();

// 2. CONFIGURACIÓN DE CORS: Vital para que tu frontend (puerto 5500) 
// pueda hablar con este backend (puerto 5050)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// 3. Habilitar el uso de CORS antes de mapear los controladores
app.UseCors();

// 4. Mapear los controladores (donde estará tu lógica de optimización)
app.MapControllers();

// 5. Configurar el puerto 5050 explícitamente si lo deseas, 
// o dejar que use el de launchSettings.json
app.Run();