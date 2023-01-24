using CitrsLite.Business.ViewModels.ParticipantViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using MudBlazor.Extensions;
using System.Text.Json;
using System.Text;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantForm
    {
        [Parameter]
        public int? Id { get; set; }

        [Inject]
        public ParticipantFormViewModel Model { get; set; }
        
        public async Task PostAysnc(EditContext context)
        {
            if(Id != null && Id > 0)
            {

                // Edit
            }
            else
            {

                var route = NavigationManager.BaseUri + "api/ParticipantAPI";

                var request = new StringContent(JsonSerializer.Serialize(Model), Encoding.UTF8, "application/json");

                var response = await HttpClient.PostAsync(route, request);

                var result = await response.Content.ReadFromJsonAsync<int>();

                Model.Id = result;
            }
            
        }


        protected override async Task OnInitializedAsync()
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();

            Model = await participantService.GetFormViewModelAsync(Id);

            Model.UserName = authState.User.Identity?.Name ?? "Unknown user";                       

        }


    }
}
