using Microsoft.EntityFrameworkCore;
using RedeSocial.Postagem.Application.Interface;
using RedeSocial.Postagem.Application.Service;
using RedeSocial.Postagem.Domain;
using RedeSocial.Postagem.Infrastructure.Context;
using RedeSocial.Postagem.Infrastructure.interfaces;
using RedeSocial.Postagem.Infrastructure.repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPostagemService, PostagemService>();
builder.Services.AddScoped<IPostagemRepository, PostagemRepository>();

builder.Services.AddDbContext<PostagemContext>(options =>
{
    options.UseSqlite(
        "Data Source=C:\\Users\\leo-b\\Documents\\estudos rodrigo\\RedeSocial-TrabalhoSenac\\db-trabalho-postagem\\postagem.db");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();