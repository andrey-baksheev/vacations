using System;
using System.Collections.Generic;
using System.Linq;
using VacationsLib;
using VacationsLib.Model;

namespace VacationsApp
{
    public class VacationsProvider: IVacation
    {
        public static VacationsContext Context
        {
            get { return new VacationsContext(); }
        }

        /*
         Check employee exists.
         */
        public void CreateEmployee(String fullname)
        {
            try
            {
                using (VacationsContext context = new VacationsContext())
                {
                    Employee employee = new Employee(fullname);
                    context.Employees.Add(employee);
                    Int32 result = context.SaveChanges();
                    Console.WriteLine("Result: {0}", result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void CreateVacation(Employee employee, Vacation vacation)
        {
            try
            {
                using (VacationsContext context = new VacationsContext())
                {
                    employee.Vacations.Add(vacation);
                    Int32 result = context.SaveChanges();
                    Console.WriteLine("Result: {0}", result);
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var results = ex.EntityValidationErrors;
                foreach (var result in results)
                {
                    Console.WriteLine("{0} {1}", result.Entry, result.IsValid);
                    foreach (var error in result.ValidationErrors)
                    {
                        Console.WriteLine("{0} {1}", error.PropertyName, error.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            try
            {
                using (VacationsContext context = new VacationsContext())
                {
                    context.Employees.Remove(employee);
                    Int32 result = context.SaveChanges();
                    Console.WriteLine("Result: {0}", result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteVacation(Vacation vacation)
        {
            try
            {
                using (VacationsContext context = new VacationsContext())
                {
                    context.Vacations.Remove(vacation);
                    Int32 result = context.SaveChanges();
                    Console.WriteLine("Result: {0}", result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public Employee FindEmployee(Int32 id)
        {
            Employee employee = null;
            try
            {
                using (VacationsContext context = new VacationsContext())
                {
                    employee = context.Employees.Where(p => p.EmployeeId == id).Single();                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return employee;
        }
    }
}
