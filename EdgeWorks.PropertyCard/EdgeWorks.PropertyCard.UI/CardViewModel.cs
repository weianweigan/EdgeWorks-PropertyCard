using CommunityToolkit.Mvvm.ComponentModel;
using EdgeWorks.PropertyCard.UI.PropertyItem;

namespace EdgeWorks.PropertyCard.UI;

public class CardViewModel:ObservableObject
{
    public PropertyTemplate? PropertyTemplate { get; set; }
}
