using CitrsLite.Data.Models;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantIndex
    {
        private IEnumerable<Participant>? participants;
        private bool _loading = false;

        private async Task getParticipants()
        {
            _loading = true;
            participants = await ParticipantService.GetParticipantsAsync(Model);            
            _loading = false;            
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
