using itSenseBL.Interfaces;
using itSenseBL.Servicios;
using itSensePersistencia.Interfaces;
using itSensePersistencia.Servicios;
using itSensePersistencia.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using pruebaItsense;

var MyAllowedSpecificOrigins = "_myAllowedSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add cors origins

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowedSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                      });
});

// Add SQL configuration
builder.Services.ConfiguracionConexionSQL(builder.Configuration);

// Add repositories
builder.Services.AddTransient(typeof(IRepositorio<>), typeof(Repositorio<>));
builder.Services.AddTransient<IRepositorioProductos, RepositorioProductos>();

// Add business logic
builder.Services.AddTransient<IProductoBL, ProductoBL>();

// Add unit of work
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowedSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
