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
    
    public partial class TeamHistoryLog
    {
        public int id { get; set; }
        public int id_team { get; set; }
        public int id_employee { get; set; }
        public string operation { get; set; }
        public Nullable<System.DateTime> when { get; set; }
    }
}
