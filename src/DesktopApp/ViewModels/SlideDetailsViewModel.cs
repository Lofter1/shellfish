using System;
using System.Collections.Generic;
using System.Reactive;
using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public class SlideDetailsViewModel : DetailsViewModelBase<Slide>
    {
        private bool _isInEditMode;
        private readonly ReactiveCommand<Unit, bool> _startEditModeCommand;
        private readonly ReactiveCommand<Unit, Unit> _cancelEditingCommand;

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