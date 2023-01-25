using CitrsLite.Data.Models;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantIndex
    {
        private IEnumerable<Participant>? participants;

        protected override void OnInitialized()
        {
            participants = new List<Participant>();
        }

        private async Task getParticipants()
        {
            participants = await ParticipantService.GetParticipantsAsync(Model);
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
