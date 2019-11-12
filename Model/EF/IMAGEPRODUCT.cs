namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IMAGEPRODUCT")]
    public partial class IMAGEPRODUCT
    {
        [Key]
        [StringLength(10)]
        public string ProductID { get; set; }

        [StringLength(50)]
        public string Image1 { get; set; }

        [StringLength(50)]
        public string Image2 { get; set; }

        [StringLength(50)]
        public string Image3 { get; set; }
    }
}
