using System;
using System.Collections.Generic;

namespace EmployeeReact.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public int? CityId { get; set; }

        public City City { get; set; }
    }
}
