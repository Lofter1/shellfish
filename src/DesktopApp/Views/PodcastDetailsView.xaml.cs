using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DesktopApp.Views
{
    public class PodcastDetailsView : Window
    {
        public PodcastDetailsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}