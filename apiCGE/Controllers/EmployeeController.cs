using apiCGE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiCGE.Controllers
{
    public class EmployeeController : ApiController
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        [HttpGet]
        public List<EmployeeVM> Employee()
        {
            try
            {
                return db.Employees.Select(x => new EmployeeVM
                {
                    Id = x.EmployeeID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Title = x.Title,
                    TitleOfCourtsey = x.TitleOfCourtesy,
                    Phone= x.HomePhone
                }).ToList();
            }
            catch
            {
                return null;
            }
        }

    }
}
