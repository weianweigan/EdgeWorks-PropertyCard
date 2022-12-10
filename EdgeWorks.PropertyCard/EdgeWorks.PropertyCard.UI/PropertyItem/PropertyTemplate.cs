using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Documents;

namespace EdgeWorks.PropertyCard.UI.PropertyItem;

public class PropertyTemplate:PropertyItem
{
    public const string PropertyTemplateExtension = ".edgeprp";

    private ObservableCollection<GroupPropertyItem> _items = new ObservableCollection<GroupPropertyItem>();

    public ObservableCollection<GroupPropertyItem> Items 
    { 
        get => _items; 
        set =>  SetProperty(ref _items , value); 
    }

    public override PropertyItemType PropertyItemType { get; set; } = PropertyItemType.Template;

    #region Static Memebers
    public static void Save(
        string filePathName,
        PropertyTemplate template)
    {
        var data = JsonConvert.SerializeObject(template);

        File.WriteAllText(filePathName,data);
    }

    public static PropertyTemplate Load(string filePathName)
    {
        var data = File.ReadAllText(filePathName);

        var template = JsonConvert.DeserializeObject<PropertyTemplate>(data);
        if (template == null)
        {
            throw new InvalidOperationException($"序列化失败,{data}");
        }

        return template;
    }

    public static string PropertySaveDir { get; } = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        nameof(PropertyTemplate));

    public static List<string> GetSavedTemplates()
    {
        if (!Directory.Exists(PropertySaveDir))
        {
            Directory.CreateDirectory(PropertySaveDir);
        }

        return Directory
            .GetFiles(PropertySaveDir)
            .Where(f => f.EndsWith(PropertyTemplateExtension, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
    #endregion
}