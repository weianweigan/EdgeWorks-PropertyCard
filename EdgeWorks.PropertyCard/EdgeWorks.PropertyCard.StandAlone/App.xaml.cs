using EdgeWorks.PropertyCard.UI;
using System.Windows;

namespace EdgeWorks.PropertyCard.StandAlone
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new CardPageBuilder();
            MainWindow.Show();
        }
    }
}
