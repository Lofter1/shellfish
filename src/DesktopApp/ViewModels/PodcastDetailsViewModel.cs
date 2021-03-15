using DesktopApp.DataAccess;
using DesktopApp.Models;

namespace DesktopApp.ViewModels
{
    public class PodcastDetailsViewModel : DetailsViewModelBase<Podcast>
    {
        protected override void Save()
        {
            using var dbContext = new ShellFishDbContext();
            dbContext.Podcasts.Add(Asset);
            dbContext.SaveChanges();
            
            RaiseItemSavedEvent();
        }
    }
}