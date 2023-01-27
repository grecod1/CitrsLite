using CitrsLite.Data.Models;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantIndex
    {
        private IEnumerable<Participant>? participants;
        private bool _loading = false;

        private async Task getParticipants()
        {
            var task = ParticipantService.GetParticipantsAsync(Model);
            _loading= true;
            await Task.Run(() => task);
            
            participants = task.Result;            

        }

        private void reset()
        {
            Model.Name = null;
            Model.Type = null;
            Model.City = null;
            Model.Phone = null;
        }

    }
}
