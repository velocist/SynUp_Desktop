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
    
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.TaskHistories = new HashSet<TaskHistory>();
        }
    
        public string id_team { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public System.DateTime priorityDate { get; set; }
        public string description { get; set; }
        public string localization { get; set; }
        public string project { get; set; }
        public Nullable<int> priority { get; set; }
        public Nullable<int> state { get; set; }
    
        public virtual Team Team { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskHistory> TaskHistories { get; set; }
    }
}
