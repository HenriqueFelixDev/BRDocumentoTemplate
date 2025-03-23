using BRDocumentoTemplate.UI.Entities;
using BRDocumentoTemplate.UI.Repositories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BRDocumentoTemplate.UI.Views.Propriedades;

public partial class PropriedadeViewModel : ObservableObject
{
    private readonly IPropriedadeRepository propriedadeRepository;

    public PropriedadeViewModel(IPropriedadeRepository propriedadeRepository)
    {
        this.propriedadeRepository = propriedadeRepository;
    }

    public ObservableCollection<PropriedadeTemplate> Propriedades { get; } = [];


    [RelayCommand]
    public async Task AdicionarPropriedade(string nomePropriedade)
    {
        PropriedadeTemplate propriedade = PropriedadeTemplate.Create(nomePropriedade);

        Propriedades.Add(propriedade);

        try
        {
            await propriedadeRepository.AdicionarAsync(propriedade);
        }
        catch (Exception)
        {
            Propriedades.Remove(propriedade);
        }
    }
}
