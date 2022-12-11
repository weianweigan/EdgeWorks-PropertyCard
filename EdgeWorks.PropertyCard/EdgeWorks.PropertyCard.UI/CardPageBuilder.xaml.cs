using System.Windows;

namespace EdgeWorks.PropertyCard.UI;

/// <summary>
/// CardPageBuilder.xaml 的交互逻辑
/// </summary>
public partial class CardPageBuilder : Window
{
    public CardPageBuilder()
    {
        InitializeComponent();
        DataContext = VM = new CardPageBuilderViewModel();
    }

    public CardPageBuilderViewModel VM { get; }
}
