using RedeSocial.Postagem.Application.Dto;

namespace RedeSocial.Postagem.Application.Interface;

public interface IPostagemService
{
    void Add(string? descricao, bool postagemPublica);

    Task<PostagemDto> GetById(Guid id);
}