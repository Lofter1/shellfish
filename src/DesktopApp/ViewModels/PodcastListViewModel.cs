using DesktopApp.Models;
using DesktopApp.Views;

namespace DesktopApp.ViewModels
{
    public class PodcastListViewModel : ListViewModelBase<Podcast>
    {
        protected override void OpenAssetDetails()
        {
            var dataContext = new PodcastDetailsViewModel {Asset = SelectedAsset, IsInEditMode = false};
            var detailsView = new PodcastDetailsView {DataContext = dataContext};

            detailsView.Show();
        }

        protected override void AddAsset()
        {
            var newPodcast = new Podcast();

            var podcastEditDataContext = new PodcastDetailsViewModel {Asset = newPodcast, IsInEditMode = true};
            var podcastEditWindow = new PodcastDetailsView {DataContext = podcastEditDataContext};

            podcastEditWindow.Show();
        }
    }
}