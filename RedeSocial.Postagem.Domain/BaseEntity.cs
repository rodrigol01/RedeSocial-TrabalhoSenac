namespace RedeSocial.Postagem.Domain;

public class BaseEntity
{
    public Guid Id { get; set; }
    
    public DateTime DataPostagem { get; set; }

    public BaseEntity()
    {
        Id = Guid.NewGuid();
        DataPostagem = DateTime.Now;
    }
}