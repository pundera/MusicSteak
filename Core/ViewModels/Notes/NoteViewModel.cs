using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels.Notes
{
    public partial class NoteViewModel : ObservableObject
    {
        [ObservableProperty]
        double y1 = 0;

        [ObservableProperty]
        double y2 = 0;
    }
}
