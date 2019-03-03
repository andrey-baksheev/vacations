using System;
using System.Runtime.Serialization;

namespace VacationsLib.Model
{
    [DataContract]
    [Serializable]
    public partial class Vacation
    {           
        [DataMember(Name ="EndDate", Order =4)]
        public DateTime EndDate { get; private set; }

        public Vacation() 
        {
           
        }
        public Vacation(DateTime startDate, Int16 duration)
        {
            this.StartDate = startDate;
            this.Duration = duration;
            this.EndDate = startDate.AddDays(duration);
        }        
    } 
}

