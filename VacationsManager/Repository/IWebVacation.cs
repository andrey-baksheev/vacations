using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacationsLib.Model;

namespace VacationsManager.Repository
{
    public interface IWebVacation
    {
        void CreateEmployee(String fullname);
        void CreateVacation(DateTime startDate, Int16 duration);
        void DeleteEmployee(Int32 employeeId);
        void DeleteVacation(Int32 vacationId);
        
        IEnumerable<Employee> SelectAllEmployees();
    }
}
