using System;
using VacationsLib.Model;
using VacationsLib;


namespace VacationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullname = "Sidorov Ivan";
            IVacation provider = new VacationsProvider();
            
            // New Employee
            provider.CreateEmployee(fullname);


            // Add vacation
            /*Employee employee = provider.FindEmployee(1);
            if (employee != null)
            { 
                Vacation vacation = new Vacation(new DateTime(2019, 6, 15), 14);
                provider.CreateVacation(employee, vacation);
            } */


            // Delete Employee
            /*Employee employee = provider.FindEmployee(1);
            if (employee != null)
            {
                provider.DeleteEmployee(employee);
            } */
        }         
    }    
}
