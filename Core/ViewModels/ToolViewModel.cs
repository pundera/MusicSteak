using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Core.Localization;
using Core.Localization.Holders;
using Core.Localization.Holders.Base;
using Core.ViewModels.Base;

namespace Core.ViewModels
{
    public partial class ToolViewModel<LT>(Language language, IMessenger messenger) 
        : VMBase<LT>(language, messenger) where LT : LTool, new()
    {
    }
}
