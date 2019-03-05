using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VacationsLib;
using VacationsLib.Model;

namespace VacationsService.Controllers
{
    public class VacationsController : ApiController
    {
        public IHttpActionResult Get()
        {
            IVacation provider = new VacationsProvider();
            List<Employee> employees = provider.SelectAllEmployees().ToList();

            /*var reports = (from emp in employees
                           select new
                           {
                               emp.Fullname,
                               emp.Vacations
                           });*/
            if (employees.Count == 0)
            {
                return NotFound();
            }

            //return Ok(reports);
            return Ok(employees);
        }

        public void AddEmployee(Employee employee)
        {
            IVacation provider = new VacationsProvider();

        }

        public void AddVacation(Employee employee, Vacation vacation)
        {
            IVacation provider = new VacationsProvider();
            provider.CreateVacation(employee, vacation);
        }

        public void DeleteEmployee(Employee employee)
        {
            IVacation provider = new VacationsProvider();
            provider.DeleteEmployee(employee);
        }

        public void DeleteVacation(Vacation vacation)
        {
            IVacation provider = new VacationsProvider();
            provider.DeleteVacation(vacation);
        }
    }
}
