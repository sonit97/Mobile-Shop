namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMPORT_COUPON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMPORT_COUPON()
        {
            IMPORT_COUPONDETAILS = new HashSet<IMPORT_COUPONDETAILS>();
        }

        [StringLength(10)]
        public string Import_CouponID { get; set; }

        public int? EmpployeeID { get; set; }

        [StringLength(10)]
        public string ProviderID { get; set; }

        public DateTime? ImportDate { get; set; }

        public virtual EMPLOYEE EMPLOYEE { get; set; }

        public virtual PROVIDER PROVIDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMPORT_COUPONDETAILS> IMPORT_COUPONDETAILS { get; set; }
    }
}
