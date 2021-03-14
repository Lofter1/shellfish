using System;
using System.Collections.Generic;
using System.Reactive;
using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public class PodcastDetailsViewModel : DetailsViewModelBase<Podcast>
    {
        private bool _isInEditMode;
        private readonly ReactiveCommand<Unit, bool> _startEditModeCommand;
        private readonly ReactiveCommand<Unit, Unit> _cancelEditingCommand;

        public PodcastDetailsViewModel()
        {
            Asset = new Podcast
            {
                Title = "Master of Pwn",
                Episode = 82,
                Speaker = new Person
                {
                    FirstName = "Jack", 
                    LastName = "Rhysider", 
                    Website = new Uri("http://www.someonefamous.com/")
                },
                Length = 75,
                PublishDate = new DateTime(2021,1, 5),
                //Url = new Uri(""),
                Tags = new List<Tag>
                {
                    new() {Name = "Hacking"}, 
                    new() {Name = "Darknet Diaries"}
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