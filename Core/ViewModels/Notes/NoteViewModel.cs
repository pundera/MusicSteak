using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Core.Messages;

namespace Core.ViewModels.Notes
{
    public partial class NoteViewModel(IMessenger messenger) : ObservableObject
    {
        readonly IMessenger messenger = messenger;

        [ObservableProperty]
        int n = 0;

        [ObservableProperty]
        int duration = 0;

        [ObservableProperty]
        bool isVisible = true;

        [ObservableProperty]
        bool isActive = false;

        [RelayCommand]
        void SwitchVisibility() 
        {
            IsVisible = !IsVisible;
        }

        [RelayCommand]
        void SwitchIsActive()
        {
            if (Duration < 5)
            {
                Duration++;
            }
            else
            {
                Duration = 0;
            }

            IsActive = !(Duration == 0);
        }

    }
}
