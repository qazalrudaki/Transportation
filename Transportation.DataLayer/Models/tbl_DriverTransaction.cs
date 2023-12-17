//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Transportation.DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_DriverTransaction
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> EnterDate { get; set; }
        public Nullable<System.DateTime> ExitDate { get; set; }
        public int DriverId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public int DriverTransactionTypeId { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual tbl_Driver tbl_Driver { get; set; }
        public virtual tbl_DriverTransactionType tbl_DriverTransactionType { get; set; }
    }
}