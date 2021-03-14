using System;
using System.Collections.Generic;
using System.Reactive;
using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public class BookDetailsViewModel : DetailsViewModelBase<Book>
    {
        private bool _isInEditMode;
        private readonly ReactiveCommand<Unit, bool> _startEditModeCommand;
        private readonly ReactiveCommand<Unit, Unit> _cancelEditingCommand;

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

            _startEditModeCommand = ReactiveCommand.Create(() => IsInEditMode = true);
            _cancelEditingCommand = ReactiveCommand.Create(CancelEditing);
        }

        public ReactiveCommand<Unit, bool> StartEditModeCommand => _startEditModeCommand;

        public ReactiveCommand<Unit, Unit> CancelEditingCommand => _cancelEditingCommand;

        public bool IsInEditMode
        {
            get => _isInEditMode; 
            private set => this.RaiseAndSetIfChanged(ref _isInEditMode, value);
        }

        private void CancelEditing()
        {
            IsInEditMode = false;
            Asset = OriginalAsset;
        }
    }
}