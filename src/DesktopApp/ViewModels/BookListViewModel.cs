using DesktopApp.Models;
using DesktopApp.Views;

namespace DesktopApp.ViewModels
{
    public class BookListViewModel : ListViewModelBase<Book>
    {
        protected override void OpenAssetDetails()
        {
            var dataContext = new BookDetailsViewModel {Asset = SelectedAsset, IsInEditMode = false};
            var detailsView = new BookDetailsView {DataContext = dataContext};

            detailsView.Show();
        }

        protected override void AddAsset()
        {
            var newBook = new Book();

            var bookEditDataContext = new BookDetailsViewModel {Asset = newBook, IsInEditMode = true};
            var bookEditWindow = new BookDetailsView {DataContext = bookEditDataContext};

            bookEditWindow.Show();
        }
    }
}