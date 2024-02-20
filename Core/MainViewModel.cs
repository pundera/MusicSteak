using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;
using Core.Messages;
using Core.ViewModels;
using Core.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Core
{
    public partial class MainViewModel(HistoryViewModel history, PropertiesViewModel properties, LayersViewModel layers, Language language, IMessenger messenger) 
        : VMBase<LMain>(language, messenger)
    {

        readonly IMessenger messenger = messenger;

        public HistoryViewModel History { get; } = history;
        public PropertiesViewModel Properties { get; } = properties;
        
        public LayersViewModel Layers { get; } = layers;

        [ObservableProperty]
        ObservableCollection<BlockViewModel> blocks = [];

        [RelayCommand]
        void AddBlock()
        {
            BlockViewModel b = new();
            Blocks.Add(b);
            b.Notes.Add(new() { Y1 = 30, Y2 = 30 });
            b.Notes.Add(new() { Y1 = 50, Y2 = 50 });
        }

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
