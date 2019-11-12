namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIZE")]
    public partial class SIZE
    {
        [StringLength(10)]
        public string SizeID { get; set; }

        [StringLength(50)]
        public string SizeType { get; set; }
    }
}
