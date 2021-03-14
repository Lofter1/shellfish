using System;
using System.Collections.Generic;
using DesktopApp.Models;

namespace DesktopApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<string> Assets { get; set; }

        public MainWindowViewModel()
        {
            Assets = new List<string>();
        }
    }
}
