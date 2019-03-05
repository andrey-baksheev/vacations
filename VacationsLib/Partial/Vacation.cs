using System;
using System.Runtime.Serialization;

namespace VacationsLib.Model
{
    [DataContract]
    [Serializable]
    public partial class Vacation
    {           
        public Vacation() 
        {
           
        }
        public Vacation(DateTime startDate, Int16 duration)
        {
            this.StartDate = startDate;
            this.Duration = duration;
        }        
    } 
}

