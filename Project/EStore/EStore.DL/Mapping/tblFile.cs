//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EStore.DL.Mapping
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblFile
    {
        public long Id { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public Nullable<long> ProductId { get; set; }
        public Nullable<long> SupplierInvoiceId { get; set; }
        public Nullable<decimal> Position { get; set; }
    
        public virtual tblProduct tblProduct { get; set; }
        public virtual tblSupplierInvoice tblSupplierInvoice { get; set; }
    }
}
