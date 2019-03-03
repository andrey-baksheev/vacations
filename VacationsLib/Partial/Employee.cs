using System;
using System.Runtime.Serialization;

namespace VacationsLib.Model
{
    [DataContract]
    [Serializable]
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
