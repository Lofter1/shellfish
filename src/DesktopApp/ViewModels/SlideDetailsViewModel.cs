using System;
using System.Collections.Generic;
using System.Reactive;
using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public class SlideDetailsViewModel : DetailsViewModelBase<Slide>
    {
        private bool isInEditMode;

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