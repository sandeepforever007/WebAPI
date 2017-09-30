using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIJQeury.Controllers
{
    public class EmployeeServiceController : ApiController
    {
        // GET: api/EmployeeService
        public IEnumerable<Employee> Get()
        {
			EmployeeDBEntities db = new EmployeeDBEntities();

			return db.Employees.ToList();
        }

        // GET: api/EmployeeService/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EmployeeService
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EmployeeService/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EmployeeService/5
        public void Delete(int id)
        {
        }
    }
}
