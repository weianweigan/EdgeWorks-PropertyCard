using System.Collections.Generic;

namespace EdgeWorks.PropertyCard.UI.PropertyItem;

public class CheckListPropetyItem : PropertyItem<List<CheckItem>>
{
    public override PropertyItemType PropertyItemType { get; set; } = PropertyItemType.CheckList;
}