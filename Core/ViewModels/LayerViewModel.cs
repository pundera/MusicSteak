using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;
using Core.Messages;
using System.Collections.ObjectModel;

namespace Core.ViewModels
{
    public partial class LayerViewModel
        : ToolViewModel<LLayer> 
    {
    
        [ObservableProperty]
        int zIndex = 99;

        [ObservableProperty]
        bool isSelected = false;

        [RelayCommand]
        void Select()
        {
            Messenger.Send<LayerSelected>(new(this));
        }

        public LayerViewModel(Language language, IMessenger messenger) : base(language, messenger)
        {
            Messenger.Register<LayerSelected>(this, (t, m) => 
            { 
                if (this.Equals(m.Value)) 
                { 
                    IsSelected = true; 
                    foreach (var b in this.Blocks) ZIndex = 99; 
                } 
                else 
                { 
                    IsSelected = false;
                    foreach (var b in this.Blocks) ZIndex = 1; 
                } 
            });
        }

        public ObservableCollection<BlockViewModel> Blocks { get; } = [];
    }
}
