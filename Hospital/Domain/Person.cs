﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    abstract class Person
    {
        public Guid Id;
        public string FirstName;
        public string LastName;
        public int Age;
    }
}
