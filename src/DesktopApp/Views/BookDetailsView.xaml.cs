using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DesktopApp.Views
{
    public class BookDetailsView : Window
    {
        public BookDetailsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}