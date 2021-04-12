using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Services.Models;

namespace WebApp.Services
{
    public interface IPatientService
    {
        Patient Get(int id);

        IEnumerable<Patient> GetAll();

        void Add(Patient newPatient);
    }
}
