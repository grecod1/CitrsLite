using CitrsLite.Business.ViewModels.ParticipantViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;

namespace CitrsLite.Pages.Participants
{
    public partial class ParticipantForm
    {
        private String Message = String.Empty;



        public void CreateParticipant(EditContext context)
        {
            var valid = context.Validate();

            if (valid)
            {
                participantService.Create(Model);
            }
            else
            {
                Message = "Error";
            }

        }


        protected override async Task OnInitializedAsync()
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();

            Model.UserName = authState.User.Identity?.Name ?? "Unknown user";
        }

        [Inject]
        public ParticipantFormViewModel Model { get; set; }

    }
}
