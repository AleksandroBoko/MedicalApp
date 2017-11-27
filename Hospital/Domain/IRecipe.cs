using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    interface IRecipe
    {
        void AddMedicine(Medicine medicine);
        void RemoveMedicine(Medicine medicine);        
        string GetInfo();

    }
}
