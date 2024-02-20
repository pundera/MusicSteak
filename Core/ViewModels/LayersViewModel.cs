using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;

namespace Core.ViewModels
{
    public partial class LayersViewModel(Language language, IMessenger messenger) 
        : ToolViewModel<LLayers>(language, messenger)
    {
    }
}
