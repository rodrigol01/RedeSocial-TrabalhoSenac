using Microsoft.AspNetCore.Mvc;
using RedeSocial.Postagem.Application.Interface;
using RedeSocial.Postagem.Dto;

namespace RedeSocial.Postagem.Controllers;

[ApiController]
[Route("[controller]")]
public class PostagensController : ControllerBase
{
    private readonly IPostagemService _postagemService;

    public PostagensController(IPostagemService postagemService)
    {
        _postagemService = postagemService;
    }

    [HttpGet("ObterPostagemPorId")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _postagemService.GetById(id));
    }

    [HttpPost("AdicionarPostagem")]
    public IActionResult Post([FromBody] InputPostDto input)
    {
        _postagemService.Add(input.Descricao, input.PostagemPublica);

        return Ok();
    }
}