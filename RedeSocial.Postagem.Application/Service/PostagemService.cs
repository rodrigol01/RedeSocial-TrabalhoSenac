using RedeSocial.Postagem.Application.Dto;
using RedeSocial.Postagem.Application.Interface;
using RedeSocial.Postagem.Domain;
using RedeSocial.Postagem.Infrastructure.interfaces;

namespace RedeSocial.Postagem.Application.Service;

public class PostagemService : IPostagemService
{
    private readonly IPostagemRepository _postagemRepository;

    public PostagemService(IPostagemRepository postagemRepository)
    {
        _postagemRepository = postagemRepository;
    }

    public void Add(string? descricao, bool postagemPublica)
    {
        _postagemRepository.Add(new PostagemEntity(descricao, postagemPublica));
    }

    public async Task<PostagemDto> GetById(Guid id)
    {
        var postagem = await _postagemRepository.GetById(id);

        return new PostagemDto()
        {
            Id = id,
            DataPostagem = postagem.DataPostagem,
            Descricao = postagem.Descricao,
            PostagemPublica = postagem.PostagemPublica,
        };
    }
}