using Fluent;
using Infragistics.Windows.OutlookBar;
using Prism.Regions;
using PrismOutlook.Core;
using System.Windows;

namespace PrismOutlook.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private readonly IRegionManager regionManager;
        private readonly IApplicationCommands applicationCommands;

        public MainWindow(IApplicationCommands applicationCommands)
        {
            InitializeComponent();
            this.applicationCommands = applicationCommands;
        }

        private void xamOutlookBar_SelectedGroupChanged(object sender, RoutedEventArgs e)
        {
            var group = ((XamOutlookBar)sender).SelectedGroup as IOutlookBarGroup;
            if (group != null)
            {
                //TODO navigate
                applicationCommands.NavigateCommand.Execute(group.DefaultNavigationPath);
            }
        }
    }
}
