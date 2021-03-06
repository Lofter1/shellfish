using DesktopApp.Models;

namespace DesktopApp.ViewModels
{
    public class DetailsViewModelBase<T> : ViewModelBase where T : Asset
    {
        public T Asset { get; set; }
    }
}