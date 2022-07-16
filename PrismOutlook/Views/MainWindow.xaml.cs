using Fluent;
using Infragistics.Windows.OutlookBar;
using System.Windows;

namespace PrismOutlook.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void xamOutlookBar_SelectedGroupChanged(object sender, RoutedEventArgs e)
        {
            var group = ((XamOutlookBar)sender).SelectedGroup;
            if (group != null)
            {
                //TODO navigate
            }
        }
    }
}
