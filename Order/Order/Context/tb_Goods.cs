//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Order.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Goods()
        {
            this.tb_CartDt = new HashSet<tb_CartDt>();
            this.tb_ReceiptDt = new HashSet<tb_ReceiptDt>();
        }
    
        public string GoodId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public Nullable<int> Price { get; set; }
        public string Describe { get; set; }
        public string Image { get; set; }
        public Nullable<int> Amount { get; set; }
        public string Supplier { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CartDt> tb_CartDt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ReceiptDt> tb_ReceiptDt { get; set; }
    }
}
