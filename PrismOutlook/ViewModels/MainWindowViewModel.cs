using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismOutlook.Core;
using System;

namespace PrismOutlook.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        private DelegateCommand<string> _navigateCommand;
        private readonly IRegionManager regionManager;

        public DelegateCommand<string> NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigateCommand));

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        private void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
            {
                throw new ArgumentNullException(nameof(navigationPath));
            }

            regionManager.RequestNavigate(RegionNames.ContentRegion, navigationPath);
        }


    }
}
