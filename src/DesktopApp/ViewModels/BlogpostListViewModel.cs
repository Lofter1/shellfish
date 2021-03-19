using DesktopApp.Models;
using DesktopApp.Views;

namespace DesktopApp.ViewModels
{
    public class BlogpostListViewModel : ListViewModelBase<Blogpost>
    {
        protected override void OpenAssetDetails()
        {
            var dataContext = new BlogpostDetailsViewModel {Asset = SelectedAsset, IsInEditMode = false};
            var detailsView = new BlogpostDetailsView {DataContext = dataContext};

            detailsView.Show();
        }

        protected override void AddAsset()
        {
            var newBlogpost = new Blogpost();

            var blogpostEditDataContext = new BlogpostDetailsViewModel {Asset = newBlogpost, IsInEditMode = true};
            var blogpostEditWindow = new BlogpostDetailsView {DataContext = blogpostEditDataContext};

            blogpostEditWindow.Show();
        }
    }
}