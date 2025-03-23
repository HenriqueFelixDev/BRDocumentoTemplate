using BRDocumentoTemplate.UI.Views.Propriedades;
using System.Windows;

namespace BRDocumentoTemplate.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new PropriedadeViewModel();
    }
}