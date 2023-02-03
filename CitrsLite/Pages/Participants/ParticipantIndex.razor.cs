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
        private bool participantsLoading = false;
        private string[]? labels;
        private double[]? chartData;

        private async Task getParticipants()
        {
            tableLoading = true;
            participantsLoading = true;
            participants = await ParticipantService.GetParticipantsAsync(Model);
            generateChart(participants);
            participantsLoading = false;
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
            participantsLoading = true;
            var fileName = "participants.xlxs";
            var url = $"/participant/excel?Name={Model.Name}&Type={Model.Type}&City={Model.City}";            
            await JS.InvokeVoidAsync("triggerFileDownload",fileName ,url);
            participantsLoading = false;
        }

        private void generateChart(IEnumerable<Participant> participants)
        {
            labels = participants.Select(p => p.Type).Distinct().ToArray();

            IList<double> counts = new List<double>();
            foreach (string label in labels)
            {
                counts.Add(participants.Count(p => p.Type == label));
            }

            chartData = counts.ToArray();
        }

    }
}
