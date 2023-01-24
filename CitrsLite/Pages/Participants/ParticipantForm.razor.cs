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

                //var route = NavigationManager.BaseUri + "api/ParticipantAPI";
                
                //var response = await HttpClient.PostAsJsonAsync(route, Model);

                //var result = await response.Content.ReadFromJsonAsync<int>();

                Model.Id = await participantService.CreateAysnc(Model);
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
