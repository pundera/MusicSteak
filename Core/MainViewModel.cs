using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Core.ViewModels;

namespace Core
{
    public partial class MainViewModel: ObservableObject
    {
        public MainViewModel(HistoryViewModel history)
        {
            History = history;
        }

        [ObservableProperty]
        string title = "Music Steak";

        [RelayCommand]
        void ShowHistory()
        {
            History.IsVisible = true;
        }

        [RelayCommand]
        void HideHistory()
        {
            History.IsVisible = false;
        }

        [ObservableProperty]
        HistoryViewModel history;
    }
}
