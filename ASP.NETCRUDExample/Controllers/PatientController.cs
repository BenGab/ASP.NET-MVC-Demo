using ASP.NETCRUDExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Services;
using WebApp.Services.Models;

namespace ASP.NETCRUDExample.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService patientService;

        public PatientController(IPatientService patientService)
        {
            this.patientService = patientService;
        }

        public IActionResult Index()
        {
            return View(new PatientViewModel());
        }

        [HttpPost]
        public IActionResult Index(PatientViewModel model)
        {
            if(ModelState.IsValid)
            {
                patientService.Add(new Patient()
                {
                    Address = model.Address,
                    Email = model.Email,
                    Name = model.Name,
                    PatientNbr = model.PatientNbr,
                    PhoneNbr = model.PhoneNbr,
                    Gender = model.Gender
                });
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
