using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reactive;
using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public abstract class ListViewModelBase<T> : ViewModelBase where T : Asset
    {
        public ObservableCollection<T> Assets { get; set; }
        public ReactiveCommand<Unit, Unit> AddAssetCommand => ReactiveCommand.Create(AddAsset);
        public ReactiveCommand<Unit, Unit> OpenAssetDetailsCommand => ReactiveCommand.Create(OpenAssetDetails);
        public ReactiveCommand<Unit, Unit> OpenAssetCommand => ReactiveCommand.Create(OpenAsset);

        public T SelectedAsset { set; get; }
        
        
        protected abstract void OpenAssetDetails();
        protected abstract void AddAsset();

        private void OpenAsset()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    Process.Start(SelectedAsset.Url.ToString());
                    break;
                case PlatformID.Unix:
                    Process.Start("xdg-open", SelectedAsset.Url.ToString());
                    break;
            }
        }
    }
}