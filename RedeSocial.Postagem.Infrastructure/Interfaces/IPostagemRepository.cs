using RedeSocial.Postagem.Domain;
using RedeSocial.Postagem.Infrastructure.repositories;

namespace RedeSocial.Postagem.Infrastructure.interfaces;

public interface IPostagemRepository : IRepositoryAsync<PostagemEntity>
{
}