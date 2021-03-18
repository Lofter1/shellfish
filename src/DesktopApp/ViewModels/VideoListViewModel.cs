using DesktopApp.Models;
using DesktopApp.Views;

namespace DesktopApp.ViewModels
{
    public class VideoListViewModel : ListViewModelBase<Video>
    {
        protected override void OpenAssetDetails()
        {
            var dataContext = new VideoDetailsViewModel {Asset = SelectedAsset, IsInEditMode = false};
            var detailsView = new VideoDetailsView {DataContext = dataContext};

            detailsView.Show();
        }

        protected override void AddAsset()
        {
            var newVideo = new Video();
            
            var videoEditDataContext = new VideoDetailsViewModel {Asset = newVideo, IsInEditMode = true};
            var videoEditWindow = new VideoDetailsView {DataContext = videoEditDataContext};

            videoEditDataContext.ItemSavedEvent += (sender, video) => Assets.Add(video);
            
            videoEditWindow.Show();
        }
    }
}