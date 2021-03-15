using DesktopApp.DataAccess;
using DesktopApp.Models;

namespace DesktopApp.ViewModels
{
    public class BlogpostDetailsViewModel : DetailsViewModelBase<Blogpost>
    {
        protected override void Save()
        {
            using var dbContext = new ShellFishDbContext();
            dbContext.Blogposts.Add(Asset);
            dbContext.SaveChanges();
            
            RaiseItemSavedEvent();
        }
    }
}