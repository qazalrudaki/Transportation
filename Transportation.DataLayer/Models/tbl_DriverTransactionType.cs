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
    
    public partial class tbl_DriverTransactionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DriverTransactionType()
        {
            this.tbl_DriverTransaction = new HashSet<tbl_DriverTransaction>();
        }
    
        public int Id { get; set; }
        public string DriverTransactionTypeText { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DriverTransaction> tbl_DriverTransaction { get; set; }
    }
}
