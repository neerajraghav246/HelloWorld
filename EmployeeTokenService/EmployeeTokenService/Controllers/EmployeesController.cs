using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDAL;

namespace EmployeeTokenService.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(var _context=new EmployeeDBEntities())
            {
                return _context.Employees.ToList();
            }
        }
    }
}
