using Microsoft.AspNetCore.Mvc;

namespace CitrsLite.Controllers
{
    public class ParticipantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Excel()
        {
            byte[] excelData = new byte[8];

            var contentType = 
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";



            return File(excelData, contentType, "report.xlxs");
        }
    }
}
