using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public class DetailsViewModelBase<T> : ViewModelBase where T : Asset
    {
        private T _asset;

        public T Asset
        {
            get => _asset;
            set
            {
                this.RaiseAndSetIfChanged(ref _asset, value);
                OriginalAsset = CommonFunctions.Clone(Asset);
            }
        }

        public T OriginalAsset { get; set; }
    }
}