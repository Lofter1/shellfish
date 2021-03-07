using System;
using System.Collections.Generic;
using System.Reactive;
using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public class PodcastDetailsViewModel : DetailsViewModelBase<Podcast>
    {
        private bool isInEditMode;

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