using BRDocumentoTemplate.UI.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BRDocumentoTemplate.UI.Views.Propriedades;

public partial class PropriedadeViewModel : ObservableObject
{
    public ObservableCollection<PropriedadeTemplate> Propriedades { get; set; } = [];


    [RelayCommand]
    public void AdicionarPropriedade(string nomePropriedade)
    {
        PropriedadeTemplate propriedade = PropriedadeTemplate.Create(nomePropriedade);

        Propriedades.Add(propriedade);
    }
}
