using RedeSocial.Postagem.Domain;
using RedeSocial.Postagem.Infrastructure.Context;
using RedeSocial.Postagem.Infrastructure.interfaces;

namespace RedeSocial.Postagem.Infrastructure.repositories;

public class PostagemRepository : BaseRepository<PostagemEntity>, IPostagemRepository
{
    public PostagemRepository(PostagemContext context) : base(context)
    {
    }
}