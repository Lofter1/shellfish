using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DesktopApp.Views
{
    public class SlideDetailsView : Window
    {
        public SlideDetailsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}