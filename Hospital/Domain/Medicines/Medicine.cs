using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{

    abstract class Medicine
    {
        public Guid id { get; }
        public string Name { get; set; }
        public string Group { get; set; }
        public double Cost { get; set; }
        
        public Medicine()
        {
            id = Guid.NewGuid();
        } 
    }
}
