namespace RedeSocial.Postagem.Infrastructure.interfaces;

public interface IRepositoryAsync<T>
{
    Task Add(T entity);

    Task<T> GetById(Guid id);
}