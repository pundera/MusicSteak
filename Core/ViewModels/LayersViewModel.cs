using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;
using System.Collections.ObjectModel;

namespace Core.ViewModels
{
    public partial class LayersViewModel(Language language, IMessenger messenger) 
        : ToolViewModel<LLayers>(language, messenger)
    {
        public ObservableCollection<LayerViewModel> Layers { get; } = [];
    }
}
