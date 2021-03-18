using DesktopApp.Models;
using DesktopApp.Views;

namespace DesktopApp.ViewModels
{
    public class SlideListViewModel : ListViewModelBase<Slide>
    {
        protected override void OpenAssetDetails()
        {
            var dataContext = new SlideDetailsViewModel {Asset = SelectedAsset, IsInEditMode = false};
            var detailsView = new SlideDetailsView {DataContext = dataContext};

            detailsView.Show();
        }

        protected override void AddAsset()
        {
            var newSlide = new Slide();
            
            var slideEditDataContext = new SlideDetailsViewModel {Asset = newSlide, IsInEditMode = true};
            var slideEditWindow = new SlideDetailsView {DataContext = slideEditDataContext};

            slideEditDataContext.ItemSavedEvent += (sender, slide) => Assets.Add(slide);
            
            slideEditWindow.Show();
        }
    }
}