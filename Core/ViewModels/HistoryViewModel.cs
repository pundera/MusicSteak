using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public partial class HistoryViewModel: ObservableObject
    {
        [ObservableProperty]
        string title = "History ....";
        [ObservableProperty]
        bool isVisible = true;
    }
}
