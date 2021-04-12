using ASP.NETCRUDExample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return View();
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
                    PhoneNbr = model.PhoneNbr
                });
            }

            return View(model);
        }
    }
}
