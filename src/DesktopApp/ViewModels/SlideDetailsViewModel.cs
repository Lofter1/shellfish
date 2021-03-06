using System;
using System.Collections.Generic;
using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public class SlideDetailsViewModel : DetailsViewModelBase<Slide>
    {
        public SlideDetailsViewModel()
        {
            Asset = new Slide
            {
                Title = "Test title",
                Event = "DefCon",
                Speaker = new Person
                {
                    FirstName = "Someone", 
                    LastName = "Famous", 
                    Website = new Uri("http://www.someonefamous.com")
                },
                FileType = "pdf",
                Url = new Uri("/path/to/file.pdf"),
                Tags = new List<Tag>
                {
                    new() {Name = "DefCon"}, 
                    new() {Name = "Someone famous wrote this"}
                }
            };
        }
    }
}