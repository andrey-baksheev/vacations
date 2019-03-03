using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VacationsLib.Model;

namespace VacationsService.Controllers
{
    public class VacationsController : ApiController
    {
        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vacation> GetVacation()
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(String fullname)
        { 
        
        }

        public void AddVacation()
        {

        }

        public void DeleteEmployee()
        {

        }

        public void DeleteVacation()
        {

        }
    }
}
