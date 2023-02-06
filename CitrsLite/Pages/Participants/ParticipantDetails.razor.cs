using CitrsLite.Business.ViewModels.ParticipantViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantDetails
    {
        [Parameter]
        public int Id { get; set; }

        private string[]? labels;
        private double[]? chartData;

        protected override async Task OnInitializedAsync()
        {
            Model = await ParticipantService.DetailsAsync(Id);
            await generateChartData();
            
        }

        private async Task getPdfAsync()
        {
            var fileName = "participants.pdf";
            var url = $"/participant/pdf/{Id}";
            await JS.InvokeVoidAsync("triggerFileDownload", fileName, url);
        }

        private async Task generateChartData()
        {
            var participants = await ParticipantService
                .GetParticipantsAsync();

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
