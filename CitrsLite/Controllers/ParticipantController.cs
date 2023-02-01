using CitrsLite.Business.Services;
using CitrsLite.Business.ViewModels.ParticipantViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CitrsLite.Controllers
{
    public class ParticipantController : Controller
    {   
        private ParticipantService _participantService;
        public ParticipantController(ParticipantService participantService)
        {
            _participantService = participantService;
        }

        [HttpGet]
        public async Task<IActionResult> Excel(ParticipantIndexViewModel model)
        {
            byte[] excelData = await _participantService.GetExcelAsync(model);

            var contentType = 
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            return File(excelData, contentType, "report.xlsx");
        }
    }
}
