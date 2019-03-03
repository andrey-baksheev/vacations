using System;
using VacationsLib.Model;
using VacationsLib;


namespace VacationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //String fullname = "Sidorov Ivan";
            IVacation provider = new VacationsProvider();

            // New Employee
            //provider.CreateEmployee(fullname);


            // Add vacation
            /*Employee employee = provider.FindEmployee(1003);
            if (employee != null)
            { 
                Vacation vacation = new Vacation(new DateTime(2020, 3, 31), 2);
                provider.CreateVacation(employee, vacation);
            }*/


            // Delete Employee
            /*Employee employee = provider.FindEmployee(1);
            if (employee != null)
            {
                provider.DeleteEmployee(employee);
            } */

            Vacation vacation = provider.FindVacation(2);
            if (vacation != null)
            {
                provider.DeleteVacation(vacation);
            }
        }
    }    
}
