using EdgeWorks.PropertyCard.UI.PropertyItem;

namespace EdgeWorks.PropertyCard.UI;

public interface IPropertyHostApp
{
    public delegate void CardStateChanged(CardState state);

    public event CardStateChanged? OnCardStateChanged;

    public void UpdatePropertiesByTemplate(PropertyTemplate propertyTemplate);
}
