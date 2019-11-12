namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVOICEDETAILS")]
    public partial class INVOICEDETAIL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string InvoiceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ProductID { get; set; }

        [StringLength(50)]
        public string Productname { get; set; }

        public int? Quantity { get; set; }

        [StringLength(10)]
        public string SizeID { get; set; }

        public decimal? PriceSale { get; set; }

        public decimal? PriceSell { get; set; }

        public virtual INVOICE INVOICE { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}
