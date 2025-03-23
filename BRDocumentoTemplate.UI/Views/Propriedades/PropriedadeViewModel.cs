using BRDocumentoTemplate.UI.Entities;
using System.Collections.ObjectModel;

namespace BRDocumentoTemplate.UI.Views.Propriedades;

public class PropriedadeViewModel
{
    public ObservableCollection<PropriedadeTemplate> Propriedades { get; set; } = [];

    public void AdicionarPropriedade(string nomePropriedade)
    {
        PropriedadeTemplate propriedade = PropriedadeTemplate.Create(nomePropriedade);

        Propriedades.Add(propriedade);
    }
}
