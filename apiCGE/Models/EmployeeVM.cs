using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiCGE.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtsey { get; set; }
        public string Phone { get; set; }

    }
}