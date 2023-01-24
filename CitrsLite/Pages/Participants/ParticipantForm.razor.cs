using CitrsLite.Business.ViewModels.ParticipantViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using MudBlazor.Extensions;
using System.Text.Json;
using System.Text;
using Microsoft.Extensions.Primitives;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantForm
    {
        [Parameter]
        public int? Id { get; set; }

        [Inject]
        public ParticipantFormViewModel Model { get; set; }

        string heading;
        public async Task PostAysnc(EditContext context)
        {
            if(Id != null && Id > 0)
            {
                await participantService.EditAsync(Model);
                await setPropertiesAsync();
            }
            else
            {
                Id = await participantService.CreateAysnc(Model);
                await setPropertiesAsync();
            }
            
        }


        protected override async Task OnInitializedAsync() => await setPropertiesAsync();        
        

        private async Task setPropertiesAsync()
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();

            Model = await participantService.GetFormViewModelAsync(Id);           
            Model.UserName = authState.User.Identity?.Name ?? "Unknown user";
            heading = Id != null ? Model.Name : "New Participant";
        }


    }
}
