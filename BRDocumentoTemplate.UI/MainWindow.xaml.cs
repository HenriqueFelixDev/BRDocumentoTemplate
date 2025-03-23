using BRDocumentoTemplate.UI.Entities;
using BRDocumentoTemplate.UI.Repositories;
using BRDocumentoTemplate.UI.RichTextElements;
using BRDocumentoTemplate.UI.Views.Propriedades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

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

    private void menuItemAdicionarPropriedade_Click(object sender, RoutedEventArgs e)
    {
        if (e.OriginalSource is MenuItem { Header: PropriedadeTemplate propriedade })
        {
            Inline placeholder = new InlinePlaceholder(propriedade.Nome);

            object parent = richText.Selection.Start.Parent;

            if (parent is Paragraph paragraph)
            {
                paragraph.Inlines.Add(placeholder);
                return;
            }

            if (parent is Run run)
            {
                richText.BeginChange();

                try
                {
                    _AdicionarPlaceholderNoRunSelecionado(run, placeholder);
                }
                finally
                {
                    richText.EndChange();
                }
                
            }
        }
    }

    private void _AdicionarPlaceholderNoRunSelecionado(Run run, Inline placeholder)
    {
        if (run.Parent is Paragraph runParagraph)
        {
            string beforePlaceholderText = richText.Selection.Start.GetTextInRun(LogicalDirection.Backward);
            string afterPlaceholderText = richText.Selection.End.GetTextInRun(LogicalDirection.Forward);

            runParagraph.Inlines.Remove(run);

            if (beforePlaceholderText.Length > 0)
            {
                runParagraph.Inlines.Add(new Run(beforePlaceholderText));
            }

            runParagraph.Inlines.Add(placeholder);

            if (afterPlaceholderText.Length > 0)
            {
                runParagraph.Inlines.Add(new Run(afterPlaceholderText));
            }
        }
    }
}