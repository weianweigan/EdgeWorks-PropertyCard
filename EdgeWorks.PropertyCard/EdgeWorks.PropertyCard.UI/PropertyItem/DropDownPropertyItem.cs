using System.Collections.ObjectModel;

namespace EdgeWorks.PropertyCard.UI.PropertyItem;

public class DropDownPropertyItem : PropertyItem<string>
{
    public ObservableCollection<string> DataItems { get; set; } = new ObservableCollection<string>();

    public bool CanInput { get; set; } = false;

    public override PropertyItemType PropertyItemType { get; set; } = PropertyItemType.DropDown;
}
