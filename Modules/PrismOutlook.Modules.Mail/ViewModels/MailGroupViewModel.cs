using Prism.Mvvm;
using PrismOutlook.Business;
using System.Collections.ObjectModel;

namespace PrismOutlook.Modules.Contacts.ViewModels
{
    public class MailGroupViewModel : BindableBase
    {
        private ObservableCollection<NavigationItem> _items;

        public ObservableCollection<NavigationItem> Items
        {
            get
            {
                return _items;
            }
            set
            { SetProperty(ref _items, value); }
        }

        public MailGroupViewModel()
        {
            GenerateMenu();
        }

        void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();

            NavigationItem root = new NavigationItem() { Caption = "Personal Folder", NavigationPath = "Mail List" };
            root.Items.Add(new NavigationItem() { Caption = "Inbox", NavigationPath = "" });
            root.Items.Add(new NavigationItem() { Caption = "Deleted", NavigationPath = "" });
            root.Items.Add(new NavigationItem() { Caption = "Sent", NavigationPath = "" });

            Items.Add(root);
        }
    }
}
