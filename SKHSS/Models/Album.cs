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
    
    public partial class Album
    {
        public Album()
        {
            this.Pictures = new HashSet<Picture>();
        }
    
        public System.Guid ALB_RecordID { get; set; }
        public string ALB_Title { get; set; }
        public string ALB_Description { get; set; }
        public System.Guid ALB_USR_RecordID { get; set; }
        public bool ALB_Private { get; set; }
    
        public virtual UserLogin UserLogin { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
