using System.Collections.ObjectModel;

namespace EdgeWorks.PropertyCard.UI.PropertyItem;

public class GroupPropertyItem : PropertyItem
{
    private ObservableCollection<PropertyItem> _items = new ObservableCollection<PropertyItem>();

    public ObservableCollection<PropertyItem> Items { get => _items; set => SetProperty(ref _items , value); }

    public override PropertyItemType PropertyItemType { get; set; } = PropertyItemType.Group;

    public bool IsExpanded { get; set; }
}
