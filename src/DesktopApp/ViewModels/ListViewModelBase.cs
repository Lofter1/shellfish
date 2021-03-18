using System.Collections.ObjectModel;
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

        public T SelectedAsset { set; get; }
        
        
        protected abstract void OpenAssetDetails();
        protected abstract void AddAsset();
    }
}