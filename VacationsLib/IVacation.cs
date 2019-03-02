using System;
using VacationsLib.Model;

namespace VacationsLib
{
    public interface IVacation
    {
        void CreateEmployee(String fullname);
        void CreateVacation(Employee employee, DateTime dateStart, Int16 duration);
        void DeleteEmployee(Employee employee);
        void DeleteVacation(Vacation vacation);
    }
}
