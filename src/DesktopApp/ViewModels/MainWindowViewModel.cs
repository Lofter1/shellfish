using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using DesktopApp.DataAccess;
using DesktopApp.Models;
using DesktopApp.Views;
using DynamicData;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            GetDataFromDatabase();
        }
        
        public BlogpostListViewModel BlogpostListViewModel { get; set; } = new BlogpostListViewModel();
        public BookListViewModel BookListViewModel { get; set; } = new BookListViewModel();
        public SlideListViewModel SlideListViewModel { get; set; } = new SlideListViewModel();
        public VideoListViewModel VideoListViewModel { get; set; } = new VideoListViewModel();
        public PodcastListViewModel PodcastListViewModel { get; set; } = new PodcastListViewModel();

        private void GetDataFromDatabase()
        {
            BookListViewModel.Assets = GetBooksFromDatabase();
            BlogpostListViewModel.Assets = GetBlogpostsFromDatabase();
            PodcastListViewModel.Assets = GetPodcastFromDatabase();
            SlideListViewModel.Assets = GetSlidesFromDatabase();
            VideoListViewModel.Assets = GetVideosFromDatabase();
        }

        private ObservableCollection<Book> GetBooksFromDatabase()
        {
            var booksFromDatabase = new ObservableCollection<Book>();
            using var dbContext = new ShellFishDbContext();
            booksFromDatabase.AddRange(dbContext.Books.ToList());

            return booksFromDatabase;
        } 
        private ObservableCollection<Blogpost> GetBlogpostsFromDatabase()
        {
            var blogpostsFromDatabase = new ObservableCollection<Blogpost>();
            using var dbContext = new ShellFishDbContext();
            blogpostsFromDatabase.AddRange(dbContext.Blogposts.ToList());

            return blogpostsFromDatabase;
        }
        private ObservableCollection<Podcast> GetPodcastFromDatabase()
        {
            var podcastsFromDatabase = new ObservableCollection<Podcast>();
            using var dbContext = new ShellFishDbContext();
            podcastsFromDatabase.AddRange(dbContext.Podcasts.ToList());

            return podcastsFromDatabase;
        }
        private ObservableCollection<Slide> GetSlidesFromDatabase()
        {
            var slidesFromDatabase = new ObservableCollection<Slide>();
            using var dbContext = new ShellFishDbContext();
            slidesFromDatabase.AddRange(dbContext.Slides.ToList());

            return slidesFromDatabase;
        }
        private ObservableCollection<Video> GetVideosFromDatabase()
        {
            var videosFromDatabase = new ObservableCollection<Video>();
            using var dbContext = new ShellFishDbContext();
            videosFromDatabase.AddRange(dbContext.Videos.ToList());

            return videosFromDatabase;
        }
    }
}
