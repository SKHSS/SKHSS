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
    
    public partial class Teammate
    {
        public System.Guid TMT_RecordID { get; set; }
        public System.Guid TMT_CLD_RecordID { get; set; }
        public int TMT_TEM_TeamID { get; set; }
        public System.Guid TMT_PMT_RecordID { get; set; }
        public int TMT_Year { get; set; }
        public int TMT_SeasonID { get; set; }
        public Nullable<int> TMT_ShirtID { get; set; }
        public bool TMT_Accepted { get; set; }
        public Nullable<System.Guid> TMT_PIC_RecordID { get; set; }
    
        public virtual Child Child { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual Team Team { get; set; }
    }
}
