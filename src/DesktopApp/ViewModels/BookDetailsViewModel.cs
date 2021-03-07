using System;
using System.Collections.Generic;
using System.Reactive;
using DesktopApp.Models;
using ReactiveUI;

using DesktopApp.Models;

namespace DesktopApp.ViewModels
{
    public class BookDetailsViewModel : DetailsViewModelBase<Book>
    {
        private bool isInEditMode;

        public BookDetailsViewModel()
        {
            Asset = new Book
            {
                Title = "Hacking: The Art of Exploitation",
                Edition = "2.",
                Author = new Person
                {
                    FirstName = "Jon", 
                    LastName = "Erickson", 
                    Website = new Uri("http://www.someonefamous.com/")
                },
                FileType = "pdf",
                //Url = new Uri(""),
                Tags = new List<Tag>
                {
                    new() {Name = "Hacking"}, 
                    new() {Name = "Someone famous wrote this"}
                },
                Cover = new Uri("ftp://path/to/file.pdf"),
                PublishDate = new DateTime(2007, 10, 1)
            };

            StartEditModeCommand = ReactiveCommand.Create(() => IsInEditMode = true);
            CancelEditingCommand = ReactiveCommand.Create(CancelEditing);
        }

        public ReactiveCommand<Unit, bool> StartEditModeCommand { get; }
        public ReactiveCommand<Unit, Unit> CancelEditingCommand { get; }

        public bool IsInEditMode
        {
            get => isInEditMode; 
            private set => this.RaiseAndSetIfChanged(ref isInEditMode, value);
        }

        private void CancelEditing()
        {
            IsInEditMode = false;
            throw new NotImplementedException();
        }
    }
}