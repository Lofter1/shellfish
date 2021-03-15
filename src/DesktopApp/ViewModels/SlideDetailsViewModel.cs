using DesktopApp.DataAccess;
using DesktopApp.Models;

namespace DesktopApp.ViewModels
{
    public class SlideDetailsViewModel : DetailsViewModelBase<Slide>
    {
        protected override void Save()
        {
            using var dbContext = new ShellFishDbContext();
            dbContext.Slides.Add(Asset);
            dbContext.SaveChanges();
            
            RaiseItemSavedEvent();
        }
    }
}