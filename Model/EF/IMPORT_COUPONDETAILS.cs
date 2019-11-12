namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMPORT_COUPONDETAILS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Import_CouponID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? Quantity { get; set; }

        [Required]
        [StringLength(10)]
        public string SizeID { get; set; }

        public decimal? PriceBuy { get; set; }

        public virtual IMPORT_COUPON IMPORT_COUPON { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}
