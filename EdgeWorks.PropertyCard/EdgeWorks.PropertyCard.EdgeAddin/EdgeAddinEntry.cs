using SolidEdgeCommunity.AddIn;
using SolidEdgeFramework;
using System.Globalization;
using System;
using System.Runtime.InteropServices;

namespace EdgeWorks.PropertyCard.EdgeAddin;

[ComVisible(true)]
[Guid("7B6E51F0-D44C-4C64-B71E-26E434BC81DA")]
[ProgId("EdgeWorks.PropertyCard.EdgeAddin.EdgeAddinEntry")]
public class EdgeAddinEntry:
    SolidEdgeAddIn    
{
    public const string EnglishTitle = "EdgeWorksPropertyCard";
    public const string EnglishDescription = "A SolidEdge addin that allow you to use property card which same as solidworks";

    public const string ChineseTitle = "SolidEdge属性卡";
    public const string ChineseDescription = "适用于SolidEdge的属性卡工具";

    public override void OnConnection(Application application, SeConnectMode ConnectMode, AddIn AddInInstance)
    {
        base.OnConnection(application, ConnectMode, AddInInstance);

        AddIn.GuiVersion = 1;

        // Put your custom OnConnection code here.
        var applicationEvents = (SolidEdgeFramework.ISEApplicationEvents_Event)application.ApplicationEvents;
        applicationEvents.AfterWindowActivate += ApplicationEvents_AfterWindowActivate; ;
    }

    private void ApplicationEvents_AfterWindowActivate(object theWindow)
    {
    }

    public override void OnDisconnection(SeDisconnectMode DisconnectMode)
    {
    }

    public override void OnCreateEdgeBarPage(
        EdgeBarController controller, 
        SolidEdgeDocument document)
    {
        var documentType = document.Type;
        // Depending on the document type, you may have different edgebar controls.
        controller.Add<PropertyCardEdgeControl>(document,1);
    }
    #region Registration functions
    [ComRegisterFunction]
    public static void OnRegister(Type t)
    {
        // See http://www.codeproject.com/Articles/839585/Solid-Edge-ST-AddIn-Architecture-Overview#Registration for registration details.
        // The following code helps write registry entries that Solid Edge needs to identify an addin. You can omit this code and
        // user installer logic if you'd like. This is simply here to help.
        try
        {
            var settings = new RegistrationSettings(t);

            settings.Enabled = true;
            //settings.Environments.Add(SolidEdgeSDK.EnvironmentCategories.Application);
            settings.Environments.Add(SolidEdgeSDK.EnvironmentCategories.AllDocumentEnvrionments);

            // See http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx for LCID details.
            var englishCulture = CultureInfo.GetCultureInfo(1033);

            // Title & Summary are Locale specific. 
            settings.Titles.Add(englishCulture, EnglishTitle);
            settings.Summaries.Add(englishCulture,EnglishDescription);

            var spanishCultere = CultureInfo.GetCultureInfo("zh-CN");
            settings.Titles.Add(spanishCultere, ChineseTitle);
            settings.Summaries.Add(spanishCultere, ChineseDescription);

            EdgeAddinEntry.Register(settings);
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.StackTrace, ex.Message);
        }
    }

    [ComUnregisterFunction]
    public static void OnUnregister(Type t)
    {
        EdgeAddinEntry.Unregister(t);
    }
    #endregion
}