using ASP.NETCRUDExample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;

namespace ASP.NETCRUDExample.Controllers
{
    [Route("api/patient")]
    [ApiController]
    public class PatientApiController : ControllerBase
    {
        private readonly IPatientService patientService;

        public PatientApiController(IPatientService patientService)
        {
            this.patientService = patientService;
        }

        [HttpGet]
        public IEnumerable<PatientViewModel> Get()
        {
            return patientService.GetAll().Select(patient => new PatientViewModel()
            {
                Address = patient.Address,
                Email = patient.Email,
                Gender = patient.Gender,
                Name = patient.Name,
                PatientNbr = patient.PatientNbr,
                PhoneNbr = patient.PhoneNbr
            });
        }

        [HttpGet("{id}")]
        public PatientViewModel Get(int id)
        {
            var response = patientService.Get(id);

            return new PatientViewModel()
            {
                Address = response.Address,
                Email = response.Email,
                Gender = response.Gender,
                Name = response.Name,
                PatientNbr = response.PatientNbr,
                PhoneNbr = response.PhoneNbr
            };
        }

        [HttpPost]
        public void Post([FromBody] PatientViewModel model)
        {
            if(ModelState.IsValid)
            {
                patientService.Add(new WebApp.Services.Models.Patient()
                {
                    Address = model.Address,
                    Email = model.Email,
                    Gender = model.Gender,
                    Name = model.Name,
                    PatientNbr = model.PatientNbr,
                    PhoneNbr = model.PhoneNbr
                });
            }
        }

        [HttpPut]
        public void Put([FromBody] PatientViewModel model)
        {
            ///TODO: call update logic
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO: call Delete logic
        }
    }
}
