using Prism.Commands;
using Prism.Mvvm;
using PrismOutlook.Business;
using PrismOutlook.Core;
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

        private DelegateCommand<NavigationItem> _selectedCommand;
        public DelegateCommand<NavigationItem> SelectedCommand =>
            _selectedCommand ?? (_selectedCommand = new DelegateCommand<NavigationItem>(ExecuteCommandName));

        public IApplicationCommands ApplicationCommands { get; }

        void ExecuteCommandName(NavigationItem navigationItem)
        {
            if (navigationItem != null)
                ApplicationCommands.NavigateCommand.Execute(navigationItem.NavigationPath);
        }

        public MailGroupViewModel(IApplicationCommands applicationCommands)
        {
            GenerateMenu();
            ApplicationCommands = applicationCommands;
        }

        void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();

            NavigationItem root = new NavigationItem() { Caption = "Personal Folder", NavigationPath = "MailList?Id=Default" };
            root.Items.Add(new NavigationItem() { Caption = "Inbox", NavigationPath = "MailList?Id=Inbox" });
            root.Items.Add(new NavigationItem() { Caption = "Deleted", NavigationPath = "MailList?Id=Deleted" });
            root.Items.Add(new NavigationItem() { Caption = "Sent", NavigationPath = "MailList?Id=Sent" });

            Items.Add(root);
        }
    }
}
