using CommunityToolkit.Mvvm.ComponentModel;
using Core.ViewModels.Notes;
using System.Collections.ObjectModel;

namespace Core.ViewModels
{
    public partial class BlockViewModel: ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<NoteViewModel> notes = [];
    }
}
