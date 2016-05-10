﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class synupEntities : DbContext
    {
        public synupEntities()
            : base("name=synupEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeLog> EmployeeLogs { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskHistory> TaskHistories { get; set; }
        public virtual DbSet<TaskHistoryLog> TaskHistoryLogs { get; set; }
        public virtual DbSet<TaskLog> TaskLogs { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamHistory> TeamHistories { get; set; }
        public virtual DbSet<TeamLog> TeamLogs { get; set; }
        public virtual DbSet<TeamHistoryLog> TeamHistoryLogs { get; set; }
    
        public virtual ObjectResult<spEmpLogD_Result> spEmpLogD(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spEmpLogD_Result>("spEmpLogD", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spEmpLogI_Result> spEmpLogI(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spEmpLogI_Result>("spEmpLogI", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spEmpLogU_Result> spEmpLogU(Nullable<int> first, Nullable<int> last)
        {
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spEmpLogU_Result>("spEmpLogU", firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spLast_Result> spLast(Nullable<int> employeeId)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLast_Result>("spLast", employeeIdParameter);
        }
    
        public virtual ObjectResult<spTasklogD_Result> spTasklogD(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spTasklogD_Result>("spTasklogD", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spTasklogI_Result> spTasklogI(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spTasklogI_Result>("spTasklogI", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spTasklogU_Result> spTasklogU(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spTasklogU_Result>("spTasklogU", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spTHisLogD_Result> spTHisLogD(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spTHisLogD_Result>("spTHisLogD", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spTHisLogI_Result> spTHisLogI(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spTHisLogI_Result>("spTHisLogI", employeeIdParameter, firstParameter, lastParameter);
        }
    
        public virtual ObjectResult<spTHisLogU_Result> spTHisLogU(string employeeId, Nullable<int> first, Nullable<int> last)
        {
            var employeeIdParameter = employeeId != null ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(string));
    
            var firstParameter = first.HasValue ?
                new ObjectParameter("first", first) :
                new ObjectParameter("first", typeof(int));
    
            var lastParameter = last.HasValue ?
                new ObjectParameter("last", last) :
                new ObjectParameter("last", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spTHisLogU_Result>("spTHisLogU", employeeIdParameter, firstParameter, lastParameter);
        }
    }
}
