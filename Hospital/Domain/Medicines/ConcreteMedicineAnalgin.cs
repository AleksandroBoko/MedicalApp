using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Medicines
{
    class ConcreteMedicineAnalgin : IMedicine
    {
        public Medicine createMedicine()
        {
            return new Analgin();
        }
    }
}
