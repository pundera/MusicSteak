using CommunityToolkit.Mvvm.Messaging.Messages;
using Core.ViewModels.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Messages
{
    internal class NoteVisibilityChanged(NoteViewModel value) : ValueChangedMessage<NoteViewModel>(value)
    {
        public NoteViewModel ToChange = value;
    }
}
