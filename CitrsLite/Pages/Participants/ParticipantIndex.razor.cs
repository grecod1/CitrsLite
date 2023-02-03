using CitrsLite.Business.ViewModels.ParticipantViewModels;
using CitrsLite.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantIndex
    {
        private IEnumerable<Participant>? participants;
        private bool loading = false;

        private async Task getParticipants()
        {
            loading = true;
            participants = await ParticipantService.GetParticipantsAsync(Model);            
            loading = false;            
        }

        private void reset()
        {
            Model.Name = null;
            Model.Type = null;
            Model.City = null;
            Model.Phone = null;
        }

        private async Task getExcel()
        {
            loading = true;
            var fileName = "participants.xlxs";
            var url = $"/participant/excel?Name={Model.Name}&Type={Model.Type}&City={Model.City}";            
            await JS.InvokeVoidAsync("triggerFileDownload",fileName ,url);
            loading = false;
        }

    }
}
