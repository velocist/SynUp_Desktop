//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SynUp_Desktop.model.pojo
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamHistory
    {
        public int id { get; set; }
        public string id_employee { get; set; }
        public string id_team { get; set; }
        public System.DateTime entranceDay { get; set; }
        public Nullable<System.DateTime> exitDate { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Team Team { get; set; }
    }
}
