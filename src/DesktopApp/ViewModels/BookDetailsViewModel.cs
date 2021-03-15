using DesktopApp.DataAccess;
using DesktopApp.Models;

namespace DesktopApp.ViewModels
{
    public class BookDetailsViewModel : DetailsViewModelBase<Book>
    {
        protected override void Save()
        {
            using var dbContext = new ShellFishDbContext();
            dbContext.Books.Add(Asset);
            dbContext.SaveChanges();

            RaiseItemSavedEvent();
        }
    }
}