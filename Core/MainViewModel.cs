using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;
using Core.Messages;
using Core.ViewModels;
using Core.ViewModels.Base;

namespace Core
{
    public partial class MainViewModel(HistoryViewModel history, Language language, IMessenger messenger) 
        : VMBase<LMain>(language, messenger)
    {
        readonly IMessenger messenger = messenger;

        public HistoryViewModel History { get; } = history;
        
        [RelayCommand]
        void Undo() { History.Undo(); }

        [RelayCommand]
        void Redo() { History.Redo(); }

        [RelayCommand]
        void English() 
        {
            var language = new Language
            {
                Current = Lang.English
            };
            var message = new LanguageChanged(language);
            messenger.Send(message);
        }

        [RelayCommand]
        void Czech() 
        {
            var language = new Language
            {
                Current = Lang.Czech
            };
            var message = new LanguageChanged(language);
            messenger.Send(message);
        }
    }
}
