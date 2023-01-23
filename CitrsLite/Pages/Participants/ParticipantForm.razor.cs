using CitrsLite.Business.ViewModels.ParticipantViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantForm
    {
        [Parameter]
        public int? Id { get; set; }

        [Inject]
        public ParticipantFormViewModel Model { get; set; }
        
        public async Task PostAysnc()
        {
            if(Id != null && Id > 0)
            {

                // Edit
            }
            else
            {
                var response = await HttpClient.PostAsJsonAsync(NavigationManager.BaseUri + "/api/ParticipantAPI", participantService);

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
