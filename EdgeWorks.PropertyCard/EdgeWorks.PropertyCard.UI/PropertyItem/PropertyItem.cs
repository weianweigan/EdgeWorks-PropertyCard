using CommunityToolkit.Mvvm.ComponentModel;

namespace EdgeWorks.PropertyCard.UI.PropertyItem;

public abstract class PropertyItem : ObservableObject
{
    private string? _name;

    public string? Name { get => _name; set => SetProperty(ref _name , value); }

    public bool IsEnable { get; set; } = true;

    public bool IsSelected { get; set; }

    public abstract PropertyItemType PropertyItemType { get; set; }
}

public abstract class PropertyItem<TValue>:PropertyItem
{
    private TValue? _value;

    public TValue? Value { get => _value; set => SetProperty(ref _value , value); }
}
