using System;
using System.Diagnostics;
using System.Reactive;
using System.Xml.Linq;
using DesktopApp.Models;
using ReactiveUI;

namespace DesktopApp.ViewModels
{
    public abstract class DetailsViewModelBase<T> : ViewModelBase where T : Asset
    {
        private T _asset;
        private bool _isInEditMode;

        public event EventHandler<T> ItemSavedEvent;

        public ReactiveCommand<Unit, bool> StartEditModeCommand => ReactiveCommand.Create(() => IsInEditMode = true);
        public ReactiveCommand<Unit, Unit> CancelEditingCommand => ReactiveCommand.Create(CancelEditing);
        public ReactiveCommand<Unit, Unit> SaveCommand => ReactiveCommand.Create(Save);
        public ReactiveCommand<Unit, Unit> OpenAssetCommand => ReactiveCommand.Create(OpenAsset);
        
        public T Asset
        {
            get => _asset;
            set
            {
                this.RaiseAndSetIfChanged(ref _asset, value);
                OriginalAsset = CommonFunctions.Clone(Asset);
            }
        }
        
        public bool IsInEditMode
        {
            get => _isInEditMode; 
            set => this.RaiseAndSetIfChanged(ref _isInEditMode, value);
        }
        
        private T OriginalAsset { get; set; }
        
        private void CancelEditing()
        {
            IsInEditMode = false;
            Asset = OriginalAsset;
        }

        protected void RaiseItemSavedEvent()
        {
            ItemSavedEvent?.Invoke(this, _asset);
        }

        protected abstract void Save();
        
        private void OpenAsset()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    Process.Start(Asset.Url.ToString());
                    break;
                case PlatformID.Unix:
                    Process.Start("xdg-open", Asset.Url.ToString());
                    break;
            }
        }
    }
}
