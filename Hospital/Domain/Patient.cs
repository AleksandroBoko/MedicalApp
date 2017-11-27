using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    class Patient:Person
    {
        public List<Medicine> Medicines { get; set; }
        public DateTime DateOfVisit { get; set; }

        public Patient()
        {
            Medicines = new List<Medicine>();
        }

    }
}
