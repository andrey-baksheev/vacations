using System;

namespace VacationsLib.Model
{
    public partial class Employee
    {
        public Employee(String fullname)
        {
            if (String.IsNullOrEmpty(fullname))
            {
                throw new ArgumentException("Fullname empty.");
            }
            this.Fullname = fullname;
        }
    }
}
