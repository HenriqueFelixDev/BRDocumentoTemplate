using BRDocumentoTemplate.UI.Entities;

namespace BRDocumentoTemplate.UI.Repositories;

public interface IPropriedadeRepository
{
    Task<PropriedadeTemplate> AdicionarAsync(PropriedadeTemplate propriedade);
    Task<IEnumerable<PropriedadeTemplate>> ListarAsync();
}

public class InMemoryPropriedadeRepository : IPropriedadeRepository
{
    private List<PropriedadeTemplate> _propriedades = [];

    public async Task<PropriedadeTemplate> AdicionarAsync(PropriedadeTemplate propriedade)
    {
        _propriedades.Add(propriedade);
        return propriedade;
    }

    public async Task<IEnumerable<PropriedadeTemplate>> ListarAsync()
    {
        return _propriedades;
    }
}