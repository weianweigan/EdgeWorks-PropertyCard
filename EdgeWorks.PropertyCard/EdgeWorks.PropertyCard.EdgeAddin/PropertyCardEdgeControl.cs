using EdgeWorks.PropertyCard.UI;
using SolidEdgeCommunity.AddIn;
using SolidEdgeFramework;
using System;
using System.Windows.Forms;
using Application = SolidEdgeFramework.Application;

namespace EdgeWorks.PropertyCard.EdgeAddin;

public partial class PropertyCardEdgeControl : EdgeBarControl
{
    private EdgeBarPage? _edgeBarPage;
    private SolidEdgeDocument? _document;
    private Application? _application;

    public PropertyCardEdgeControl()
    {
        InitializeComponent();
        CardElementHost.Dock = DockStyle.Fill;
        CardElementHost.Child = new Card();
    }

    private void MyEdgeBarControl_AfterInitialize(object sender, EventArgs e)
    {
        // These properties are not initialized until AfterInitialize is called.
        _edgeBarPage = this.EdgeBarPage;
        _document = this.Document;
        _application = _document.Application;     
    }
}
