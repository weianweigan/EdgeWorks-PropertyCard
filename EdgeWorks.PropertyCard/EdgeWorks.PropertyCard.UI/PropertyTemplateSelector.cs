using EdgeWorks.PropertyCard.UI.PropertyItem;
using System;
using System.Windows;
using System.Windows.Controls;

namespace EdgeWorks.PropertyCard.UI;

public class PropertyTemplateSelector : DataTemplateSelector
{
    #region DataTemplate
    public DataTemplate? BoolDataTemplate { get; set; }

    public DataTemplate? StringDataTemplate { get; set; }

    public DataTemplate? CheckListDataTemplate { get; set; }

    public DataTemplate? DoubleDataTemplate { get; set; }

    public DataTemplate? DropDownDataTemplate { get; set; }

    public DataTemplate? GroupDataTemplate { get; set; }
    #endregion

    public override DataTemplate? SelectTemplate(object? item, DependencyObject container)
    {
        return item switch
        {
            null => null,
            BoolPropertyItem => BoolDataTemplate,
            StringPropertyItem => StringDataTemplate,
            CheckListPropetyItem => CheckListDataTemplate,
            DoublePropertyItem => DoubleDataTemplate,
            DropDownPropertyItem => DropDownDataTemplate,
            GroupPropertyItem => GroupDataTemplate,
            _ => throw new NotSupportedException(item.ToString())
        };
    }
}
