using Microsoft.EntityFrameworkCore;
using RedeSocial.Postagem.Domain;

namespace RedeSocial.Postagem.Infrastructure.Context;

public class PostagemContext : DbContext
{
    public PostagemContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<PostagemEntity> PostagemEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}