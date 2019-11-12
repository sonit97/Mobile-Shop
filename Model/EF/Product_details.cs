namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_details
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Color { get; set; }

        public decimal? Price { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string SizeID { get; set; }

       

        public int? Quanlity { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}
