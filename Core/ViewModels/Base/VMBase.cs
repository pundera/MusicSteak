using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Factory;
using Core.Localization.Holders.Base;
using Core.Messages;

namespace Core.ViewModels.Base
{
    public abstract partial class VMBase<TLocalization> : ObservableObject where TLocalization : LBase, new() 
    {
        protected VMBase(Language language, IMessenger messenger)
        {
            this.language = language;
            Language = language;
            messenger.Register(this, (MessageHandler<VMBase<TLocalization>, LanguageChanged>)((vm, message) => { 
                vm.Language = message.ChangedTo; }));
        }

        private Language language;
        public Language Language { get => language; set { language = value; L = LanguageFactory<TLocalization>.Init<TLocalization>(value); } }

        [ObservableProperty]
        TLocalization? l;
    }
}
