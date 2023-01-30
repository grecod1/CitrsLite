using CitrsLite.Business.ViewModels.ParticipantViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using MudBlazor.Extensions;
using System.Text.Json;
using System.Text;
using Microsoft.Extensions.Primitives;
using MudBlazor;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantForm
    {
        string heading = "New Participant";


        [Inject]
        public ParticipantFormViewModel Model { get; set; }

        
        protected override async Task OnParametersSetAsync() => await setPropertiesAsync();

        [Parameter]
        public int? Id { get; set; } = null;

       
        private async Task postAysnc(EditContext context)    
        {
            if(Id != null && Id > 0)
            {
                await ParticipantService.EditAsync(Model);
                Snackbar.Add("Edit Complete", Severity.Success);
                await setPropertiesAsync();
            }
            else
            {
                Id = await ParticipantService.CreateAysnc(Model);
                Snackbar.Add("Participant Created", Severity.Success);
                await setPropertiesAsync();
            }
            
        }

                
        private async Task setPropertiesAsync()
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();

            Model = await ParticipantService.GetFormViewModelAsync(Id);           
            Model.UserName = authState.User.Identity?.Name ?? "Unknown user";
            heading = Id != null ? Model.Name : "New Participant";
        }


    }
}
