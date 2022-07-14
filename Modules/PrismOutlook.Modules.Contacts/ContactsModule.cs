using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismOutlook.Core;
using PrismOutlook.Modules.Contacts.Menus;
using PrismOutlook.Modules.Contacts.Views;

namespace PrismOutlook.Modules.Contacts
{
    public class ContactsModule : IModule
    {
        private readonly IRegionManager regionManager;

        public ContactsModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }


        public void OnInitialized(IContainerProvider containerProvider)
        {
            regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(ContactsGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}