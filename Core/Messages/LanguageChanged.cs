using CommunityToolkit.Mvvm.Messaging.Messages;
using Core.Localization;

namespace Core.Messages
{
    public class LanguageChanged(Language value) : ValueChangedMessage<Language>(value)
    {
        public Language ChangedTo { get; private set; } = value;
    }
}
