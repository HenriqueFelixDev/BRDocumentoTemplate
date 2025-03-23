using BRDocumentoTemplate.UI.Repositories;
using BRDocumentoTemplate.UI.Views.Propriedades;
using System.Windows;

namespace BRDocumentoTemplate.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly PropriedadeViewModel propriedadeViewModel;

    public MainWindow()
    {
        InitializeComponent();
        propriedadeViewModel = new PropriedadeViewModel(new InMemoryPropriedadeRepository());
        DataContext = propriedadeViewModel;
    }

    private void buttonAdicionarPropriedade_Click(object sender, RoutedEventArgs e)
    {
        new DialogAdicionarPropriedade(propriedadeViewModel).ShowDialog();
    }
}