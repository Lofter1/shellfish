using DesktopApp.DataAccess;
using DesktopApp.Models;

namespace DesktopApp.ViewModels
{
    public class VideoDetailsViewModel : DetailsViewModelBase<Video>
    {
        protected override void Save()
        {
            using var dbContext = new ShellFishDbContext();
            dbContext.Videos.Add(Asset);
            dbContext.SaveChanges();
            
            RaiseItemSavedEvent();
        }
    }
}