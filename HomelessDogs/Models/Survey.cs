//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomelessDogs.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Survey
    {
        public int Id_survey { get; set; }
        public Nullable<int> Id_dog { get; set; }
        public Nullable<int> Id_doctor { get; set; }
        public Nullable<int> Id_status { get; set; }
        public string Illness { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Comment { get; set; }
    
        public virtual Dog Dog { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Status Status { get; set; }
    }
}
