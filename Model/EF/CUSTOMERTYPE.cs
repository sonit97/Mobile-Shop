namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMERTYPE")]
    public partial class CUSTOMERTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMERTYPE()
        {
            CUSTOMERS = new HashSet<CUSTOMER>();
        }

        [StringLength(10)]
        public string CustomerTypeID { get; set; }

        [StringLength(50)]
        public string CustomerTypeName { get; set; }

        public double? Sale { get; set; }

        public int? Rank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER> CUSTOMERS { get; set; }
    }
}
