using Microsoft.EntityFrameworkCore;
using RedeSocial.Postagem.Domain;
using RedeSocial.Postagem.Infrastructure.Context;
using RedeSocial.Postagem.Infrastructure.interfaces;

namespace RedeSocial.Postagem.Infrastructure.repositories;

public class BaseRepository<T> : IRepositoryAsync<T> where T : BaseEntity
{
    private readonly PostagemContext _context;

    public BaseRepository(PostagemContext context)
    {
        _context = context;
    }
    
    public async Task Add(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<T> GetById(Guid id)
    {
        return await _context.Set<T>().FirstAsync(x => x.Id == id);
    }
}