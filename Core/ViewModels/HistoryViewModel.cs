using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;
using Core.ViewModels.Base;

namespace Core.ViewModels
{
    public partial class HistoryViewModel(Language language, IMessenger messenger) 
        : VMBase<LHistory>(language, messenger)
    {
        [ObservableProperty]
        string title = "History ....";
        [ObservableProperty]
        bool isVisible = true;

        internal void Redo()
        {
            throw new NotImplementedException();
        }

        internal void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
