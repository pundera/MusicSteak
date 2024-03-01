using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Core.ViewModels.Notes;
using System.Collections.ObjectModel;

namespace Core.ViewModels
{
    public partial class BlockViewModel: ObservableObject
    {
        public BlockViewModel(IMessenger messenger): base()
        {
            for (int ix = 24; ix > -13; ix--) Notes.Add(new(messenger) { IsVisible = true, N = ix }) ;
        }

        public ObservableCollection<NoteViewModel> Notes { get; } = [];

        [ObservableProperty]
        int zIndex = 99;

    }
}