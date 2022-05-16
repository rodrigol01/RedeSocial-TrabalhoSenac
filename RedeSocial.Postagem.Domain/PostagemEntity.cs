namespace RedeSocial.Postagem.Domain;

public class PostagemEntity : BaseEntity
{
    public string? Descricao { get; set; }
    
    public bool PostagemPublica { get; set; }
    
    public PostagemEntity(string? descricao, bool postagemPublica)
    {
        Descricao = descricao;
        PostagemPublica = postagemPublica;
    }
}