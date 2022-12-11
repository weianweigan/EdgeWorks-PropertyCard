using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EdgeWorks.PropertyCard.UI.PropertyItem;
using System;
using System.Linq;
using System.Windows;

namespace EdgeWorks.PropertyCard.UI;

public enum CardState
{
	NoTemplate,
	NoDocument,
	Normal,
}

public partial class CardViewModel : ObservableObject
{
	private CardPageBuilder? _cardPageBuilder;

	public CardViewModel()
	{

	}

	[ObservableProperty]
	private CardState _cardState = CardState.NoTemplate;

	[ObservableProperty]
	private PropertyTemplate? _propertyTemplate;

	public CardPageBuilder CardPageBuilder { get => _cardPageBuilder ??= CreateBuilder();}

	[RelayCommand]
	private void Create()
	{
		CardPageBuilder?.Show();
	}

	[RelayCommand]
	private void Refresh()
	{
		try
		{
            var template = PropertyTemplate.GetSavedTemplates()?.FirstOrDefault();
            PropertyTemplate = PropertyTemplate.Load(template);
        }
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);		}
	}

	[RelayCommand]
	public void MoreProperties()
	{

	}

	[RelayCommand]
	public void PropertySettings()
	{

	}

	[RelayCommand]
	private void ReSet()
	{

	}

	[RelayCommand]
	private void Apply()
	{

	}

    private CardPageBuilder CreateBuilder()
    {
        var page = new CardPageBuilder();
        page.Closed += Page_Closed;
        return page;
    }

    private void Page_Closed(object sender, EventArgs e)
    {
        CardPageBuilder.Closed -= Page_Closed;
        _cardPageBuilder = null;
    }
}
