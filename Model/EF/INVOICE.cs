namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVOICE")]
    public partial class INVOICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVOICE()
        {
            INVOICEDETAILS = new HashSet<INVOICEDETAIL>();
        }

        [StringLength(50)]
        public string InvoiceID { get; set; }

        public int? EmpployeeID { get; set; }

        public int? CustomerID { get; set; }

        public DateTime OderDate { get; set; }

        [StringLength(50)]
        public string DeliveryAddress { get; set; }

        [StringLength(50)]
        public string OrderStatus { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        public virtual EMPLOYEE EMPLOYEE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVOICEDETAIL> INVOICEDETAILS { get; set; }
    }
}
