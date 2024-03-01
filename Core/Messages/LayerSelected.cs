using CommunityToolkit.Mvvm.Messaging.Messages;
using Core.ViewModels;

namespace Core.Messages
{
    public class LayerSelected(LayerViewModel value) : ValueChangedMessage<LayerViewModel>(value)
    {
    }
}
