using MinimalApi.Infraestrutura.Db;
using MinimalApi.DTOs;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Interfaces
using MinimalApi.Dominio.Servicos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options => {
    options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    );
});

var app = builder.Build();

app.MapGet("/", () => "Olá pessoal!");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico AdministradorServico) =>
{
    if (AdministradorServico.Login(loginDTO) != null)
        return Results.Ok("Login efetuado com sucesso!");
    else
        return Results.Unauthorized();
});

app.Run();
