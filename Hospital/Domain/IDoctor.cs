using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    interface IDoctor
    {
        void AddPatient(Person person);
        void RemovePatient(Person person);
        Person GetPatientById(Guid id);
        Person GetPatientByIndex(int index);        
        List<string> GetAllReports();
    }
}
