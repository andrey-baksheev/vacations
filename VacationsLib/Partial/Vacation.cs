using System;

namespace VacationsLib.Model
{
    public partial class Vacation
    {
        public DateTime EndDate { get; private set; }

        private Vacation() { }
        public Vacation(DateTime startDate, Int16 duration)
        {
            this.StartDate = startDate;
            this.Duration = duration;
            this.EndDate = startDate.AddDays(duration);
        }
    } 
}

