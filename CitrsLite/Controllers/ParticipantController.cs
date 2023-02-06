using CitrsLite.Business.Services;
using CitrsLite.Business.ViewModels.ParticipantViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;


namespace CitrsLite.Controllers
{
    public class ParticipantController : Controller
    {   
        private ParticipantService _participantService;
        private IWebHostEnvironment _appEnvironment;

        public ParticipantController(ParticipantService participantService, 
            IWebHostEnvironment appEnvironment)
        {
            _participantService = participantService;            
            _appEnvironment = appEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Excel(ParticipantIndexViewModel model)
        {
            byte[] excelData = await _participantService.GetExcelAsync(model);

            var contentType = 
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            return File(excelData, contentType, "report.xlsx");
        }

        [HttpGet]        
        public async Task<IActionResult> Pdf(int id)
        {            

            
            var pdfData =  _participantService.GetPDF(id, _appEnvironment.WebRootPath);

            return File(pdfData, "application/pdf", "participant.pdf");
        }
    }
}
