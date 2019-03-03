using System;
using VacationsLib.Model;

namespace VacationsLib
{
    public interface IVacation
    {
        void CreateEmployee(String fullname);
        void CreateVacation(Employee employee, Vacation vacation);
        void DeleteEmployee(Employee employee);
        void DeleteVacation(Vacation vacation);

        Employee FindEmployee(Int32 id);
        Vacation FindVacation(Int32 id);
    }
}
