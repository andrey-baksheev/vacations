//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VacationsLib.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vacation
    {
        public int VacationId { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public short Duration { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}