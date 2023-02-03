using CitrsLite.Business.ViewModels.ParticipantViewModels;
using CitrsLite.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantIndex
    {
        private IEnumerable<Participant>? participants;
        private bool tableLoading = false;
        private bool excelLoading = false;

        private async Task getParticipants()
        {
            tableLoading = true;
            participants = await ParticipantService.GetParticipantsAsync(Model);            
            tableLoading = false;            
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
            excelLoading = true;
            var fileName = "participants.xlxs";
            var url = $"/participant/excel?Name={Model.Name}&Type={Model.Type}&City={Model.City}";            
            await JS.InvokeVoidAsync("triggerFileDownload",fileName ,url);
            excelLoading = false;
        }

    }
}
