using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;

namespace Core.ViewModels
{
    public partial class HistoryViewModel(Language language, IMessenger messenger) 
        : ToolViewModel<LHistory>(language, messenger)
    {
        [RelayCommand]
        void Redo()
        {
            throw new NotImplementedException();
        }

        [RelayCommand]
        void Undo()
        {
            throw new NotImplementedException();
        }

    }
}
