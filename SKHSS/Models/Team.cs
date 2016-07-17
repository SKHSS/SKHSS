//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SKHSS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Team
    {
        public Team()
        {
            this.Coaches = new HashSet<Coach>();
            this.Teammates = new HashSet<Teammate>();
        }
    
        public int TEM_TeamID { get; set; }
        public string TEM_TeamName { get; set; }
        public Nullable<System.Guid> TEM_PIC_RecordID { get; set; }
        public int TEM_MinAge { get; set; }
        public int TEM_MaxAge { get; set; }
        public Nullable<bool> TEM_Gender { get; set; }
        public bool TEM_Enabled { get; set; }
    
        public virtual ICollection<Coach> Coaches { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual ICollection<Teammate> Teammates { get; set; }
    }
}
