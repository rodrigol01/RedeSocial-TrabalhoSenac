namespace RedeSocial.Postagem.Application.Dto;

public class PostagemDto
{
    public Guid Id { get; set; }
    
    public DateTime DataPostagem { get; set; }
    
    public string? Descricao { get; set; }
    
    public bool PostagemPublica { get; set; }
}