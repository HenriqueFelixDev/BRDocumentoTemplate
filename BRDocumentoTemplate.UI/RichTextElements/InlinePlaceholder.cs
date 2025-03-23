using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace BRDocumentoTemplate.UI.RichTextElements;

public class InlinePlaceholder : InlineUIContainer
{
    public InlinePlaceholder(string text)
    {
        Child = new Border
        {
            CornerRadius = new CornerRadius(5),
            Padding = new Thickness(8, 2, 8, 2),
            Background = Brushes.Red,
            Child = new TextBlock
            {
                Text = text,
                Foreground = Brushes.White,
            }
        };
    }
}
