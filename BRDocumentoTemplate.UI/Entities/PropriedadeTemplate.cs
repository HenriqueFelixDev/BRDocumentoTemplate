namespace BRDocumentoTemplate.UI.Entities;

public class PropriedadeTemplate
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    public static PropriedadeTemplate Create(string nome)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(nome);

        return new PropriedadeTemplate
        {
            Id = Guid.NewGuid(),
            Nome = nome,
        };
    }
}
