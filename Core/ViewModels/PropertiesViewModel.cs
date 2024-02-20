using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;

namespace Core.ViewModels
{
    public partial class PropertiesViewModel(Language language, IMessenger messenger) 
        : ToolViewModel<LProperties>(language, messenger)
    {
    }
}
