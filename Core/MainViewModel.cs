using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;
using Core.Messages;
using Core.ViewModels;
using Core.ViewModels.Base;

namespace Core
{
    public partial class MainViewModel(HistoryViewModel history, PropertiesViewModel properties, LayersViewModel layers, Language language, IMessenger messenger) 
        : VMBase<LMain>(language, messenger)
    {

        readonly IMessenger messenger = messenger;

        public HistoryViewModel History { get; } = history;
        public PropertiesViewModel Properties { get; } = properties;
        
        public LayersViewModel Layers { get; } = layers;

        public BlockViewModel Notes { get; } = new BlockViewModel(messenger);

        [RelayCommand]
        void AddBlock()
        {

            for (int lx = 0; lx < 2; lx++)
            {
                var l = new LayerViewModel(language, messenger)
                {
                    IsSelected = lx == 0
                };

                Layers.Layers.Add(l);
                l.Title = $"{lx} {l.L!.Title}";

                
                for (int ix = 0; ix < 16; ix++)
                {
                    BlockViewModel b = new(messenger);
                    l.Blocks.Add(b);
                }
            }
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
