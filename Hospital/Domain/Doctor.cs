using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    class Doctor:Person, IDoctor
    {
        List<Person> Patients;

        public Doctor()
        {
            Patients = new List<Person>();
        }

        public void AddPatient(Person person)
        {
            Patients.Add(person);
        }

        public List<string> GetAllReports()
        {
            return new List<string>();
        }

        public Person GetPatientById(Guid id)
        {
            return Patients.Where(n => n.Id == id).First();
        }

        public Person GetPatientByIndex(int index)
        {
            return Patients[index];
        }

        public string GetLastReport(Person person)
        {
            return new string('s',1);
        }

        public void RemovePatient(Person person)
        {
            Patients.Remove(person);
        }
    }
}
