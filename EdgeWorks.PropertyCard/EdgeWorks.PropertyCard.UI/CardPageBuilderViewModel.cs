using CommunityToolkit.Mvvm.ComponentModel;
using EdgeWorks.PropertyCard.UI.PropertyItem;
using System.Collections.Generic;

namespace EdgeWorks.PropertyCard.UI;

public class CardPageBuilderViewModel : ObservableObject
{
    private PropertyTemplate _propertyTemplate = new PropertyTemplate();

    public int SelectedTemplateIndex { get; set; }

    public PropertyTemplate PropertyTemplate { 
        get => _propertyTemplate; 
        set => SetProperty(ref _propertyTemplate ,value); }


}
