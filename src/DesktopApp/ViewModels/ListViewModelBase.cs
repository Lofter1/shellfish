using System.Collections.ObjectModel;
using System.Reactive;
using DesktopApp.DataAccess;
using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public abstract class ListViewModelBase<T> : ViewModelBase where T : Asset
    {
        public ObservableCollection<T> Assets { get; set; }
        public ReactiveCommand<Unit, Unit> AddAssetCommand => ReactiveCommand.Create(AddAsset);
        public ReactiveCommand<Unit, Unit> OpenAssetDetailsCommand => ReactiveCommand.Create(OpenAssetDetails);
        
        public ReactiveCommand<Unit, Unit> DeleteAssetCommand => ReactiveCommand.Create(DeleteAsset);

        public T SelectedAsset { set; get; }
        
        
        protected abstract void OpenAssetDetails();
        protected abstract void AddAsset();

        public void DeleteAsset()
        {
            using var dbContext = new ShellFishDbContext();
            dbContext.Remove(SelectedAsset);
            dbContext.SaveChanges();
            Assets.Remove(SelectedAsset);
        }
    }
}