using System.Windows;

namespace BRDocumentoTemplate.UI.Views.Propriedades;

/// <summary>
/// Lógica interna para DialogAdicionarPropriedade.xaml
/// </summary>
public partial class DialogAdicionarPropriedade : Window
{
    public DialogAdicionarPropriedade(PropriedadeViewModel propriedadeViewModel)
    {
        InitializeComponent();
        DataContext = propriedadeViewModel;
    }

    private void buttonCancelar_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
    }

    private void buttonAdicionar_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
    }
}
