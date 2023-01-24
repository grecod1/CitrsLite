using CitrsLite.Business.Services;
using CitrsLite.Business.ViewModels.ParticipantViewModels;
using CitrsLite.Data.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitrsLite.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantAPIController : ControllerBase
    {
        private ParticipantService _participantService;
        
        public ParticipantAPIController(ParticipantService participantService)
        {
            _participantService = participantService;            
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(ParticipantFormViewModel model)
        {

            var model2 = model;

            return await _participantService.CreateAysnc(model);           
        }

        [HttpGet]
        public Participant Get()
        {

            return _participantService.GetParticipant(new ParticipantFormViewModel());
        }
    }
}
