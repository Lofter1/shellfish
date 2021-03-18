using System.Collections.ObjectModel;
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
        
        public ObservableCollection<Book> Books { get; set; }
        public ObservableCollection<Blogpost> Blogposts { get; set; }
        public ObservableCollection<Podcast> Podcasts { get; set; }
        public ObservableCollection<Slide> Slides { get; set; }
        public ObservableCollection<Video> Videos { get; set; }
        
        public ReactiveCommand<Unit, Unit> AddBookCommand => ReactiveCommand.Create(AddBook);
        public ReactiveCommand<Unit, Unit> AddBlogpostCommand => ReactiveCommand.Create(AddBlogpost);
        public ReactiveCommand<Unit, Unit> AddPodcastCommand => ReactiveCommand.Create(AddPodcast);
        public ReactiveCommand<Unit, Unit> AddSlideCommand => ReactiveCommand.Create(AddSlide);
        public ReactiveCommand<Unit, Unit> AddVideoCommand => ReactiveCommand.Create(AddVideo);
        
        public ReactiveCommand<Unit, Unit> OpenPodcastCommand => ReactiveCommand.Create(OpenPodcast);

        public Podcast SelectedPodcast
        {
            get; set;
        }
        
        private void OpenPodcast()
        {
            var podcastEditDataContext = new PodcastDetailsViewModel {Asset = SelectedPodcast, IsInEditMode = false};
            var podcastEditWindow = new PodcastDetailsView {DataContext = podcastEditDataContext};

            podcastEditWindow.Show();
        }
        
        private void AddBook()
        {
            var newBook = new Book();

            var bookEditDataContext = new BookDetailsViewModel {Asset = newBook, IsInEditMode = true};
            var bookEditWindow = new BookDetailsView {DataContext = bookEditDataContext};
         
            bookEditDataContext.ItemSavedEvent += (sender, book) => Books.Add(book);

            bookEditWindow.Show();
        }
        private void AddBlogpost()
        {
            var newBlogpost = new Blogpost();

            var blogpostEditDataContext = new BlogpostDetailsViewModel {Asset = newBlogpost, IsInEditMode = true};
            var blogpostEditWindow = new BlogpostDetailsView {DataContext = blogpostEditDataContext};

            blogpostEditDataContext.ItemSavedEvent += (sender, blogpost) => Blogposts.Add(blogpost);
            
            blogpostEditWindow.Show();
        }
        private void AddPodcast()
        {
            var newPodcast = new Podcast();

            var podcastEditDataContext = new PodcastDetailsViewModel {Asset = newPodcast, IsInEditMode = true};
            var podcastEditWindow = new PodcastDetailsView {DataContext = podcastEditDataContext};

            podcastEditDataContext.ItemSavedEvent += (sender, podcast) => Podcasts.Add(podcast);
            
            podcastEditWindow.Show();
        }
        private void AddSlide()
        {
            var newSlide = new Slide();
            
            var slideEditDataContext = new SlideDetailsViewModel {Asset = newSlide, IsInEditMode = true};
            var slideEditWindow = new SlideDetailsView {DataContext = slideEditDataContext};

            slideEditDataContext.ItemSavedEvent += (sender, slide) => Slides.Add(slide);
            
            slideEditWindow.Show();
        }
        private void AddVideo()
        {
            var newVideo = new Video();
            
            var videoEditDataContext = new VideoDetailsViewModel {Asset = newVideo, IsInEditMode = true};
            var videoEditWindow = new VideoDetailsView {DataContext = videoEditDataContext};

            videoEditDataContext.ItemSavedEvent += (sender, video) => Videos.Add(video);
            
            videoEditWindow.Show();
        }

        private void GetDataFromDatabase()
        {
            Books = GetBooksFromDatabase();
            Blogposts = GetBlogpostsFromDatabase();
            Podcasts = GetPodcastFromDatabase();
            Slides = GetSlidesFromDatabase();
            Videos = GetVideosFromDatabase();
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
