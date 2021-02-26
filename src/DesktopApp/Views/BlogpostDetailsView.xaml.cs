using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DesktopApp.Views
{
    public class BlogpostDetailsView : Window
    {
        public BlogpostDetailsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}