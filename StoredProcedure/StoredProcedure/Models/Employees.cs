﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProcedure.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}