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
    
    public partial class EmpAttribute
    {
        public int EmployeeId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
    
        public virtual Attribute Attribute { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
