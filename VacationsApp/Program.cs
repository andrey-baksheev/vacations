using System;
using VacationsLib.Model;


namespace VacationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullname = "Petrov Ivan";
            VacationsProvider provider = new VacationsProvider();
            //provider.CreateEmployee(fullname);

            Employee employee = provider.FindEmployee(1);
            if (employee != null)
            { 
                Vacation vacation = new Vacation(new DateTime(2019, 6, 15), 14);
                provider.CreateVacation(employee, vacation);
            }
        }         
    }    
}
