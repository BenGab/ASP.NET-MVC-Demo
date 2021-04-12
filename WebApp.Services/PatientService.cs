using System.Collections.Generic;
using System.Threading;
using WebApp.Repositories;
using WebApp.Services.Models;

namespace WebApp.Services
{
    public class PatientService : IPatientService
{
        private readonly IRepository<Patient> repository;
        private int id = 0;

        public PatientService(IRepository<Patient> repository)
        {
            this.repository = repository;
        }
        public void Add(Patient newPatient)
        {
            Interlocked.Increment(ref id);
            newPatient.Id = id;
            repository.Add(id, newPatient);
        }

        public Patient Get(int id)
        {
            return repository.Get(id);
        }

        public IEnumerable<Patient> GetAll()
        {
            return repository.GetAll();
        }
    }
}
