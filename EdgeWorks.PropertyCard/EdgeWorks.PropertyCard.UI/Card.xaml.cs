using System.Windows.Controls;

namespace EdgeWorks.PropertyCard.UI;

/// <summary>
/// Card.xaml 的交互逻辑
/// </summary>
public partial class Card : UserControl
{
    private CardViewModel _vm;

    public Card()
    {
        InitializeComponent();
        DataContext = _vm = new CardViewModel();
    }
}
