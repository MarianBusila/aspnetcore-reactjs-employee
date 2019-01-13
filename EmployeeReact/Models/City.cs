﻿using System;
using System.Collections.Generic;

namespace EmployeeReact.Models
{
    public partial class City
    {
        public City()
        {
            Employee = new HashSet<Employee>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
