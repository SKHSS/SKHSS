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
    
    public partial class Feedback
    {
        public System.Guid FBK_RecordID { get; set; }
        public Nullable<System.Guid> FBK_USR_RecordID { get; set; }
        public string FBK_Name { get; set; }
        public string FBK_Email { get; set; }
        public string FBK_Message { get; set; }
        public string FBK_Browser { get; set; }
        public string FBK_OS { get; set; }
        public string FBK_BrowserString { get; set; }
        public bool FBK_Viewed { get; set; }
        public bool FBK_Complete { get; set; }
        public System.DateTime FBK_Date { get; set; }
    
        public virtual UserLogin UserLogin { get; set; }
    }
}
