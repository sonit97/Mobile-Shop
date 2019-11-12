namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCTS")]
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            IMPORT_COUPONDETAILS = new HashSet<IMPORT_COUPONDETAILS>();
            INVOICEDETAILS = new HashSet<INVOICEDETAIL>();
            Product_details = new HashSet<Product_details>();
        }

        [StringLength(10)]
        public string ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public string Descripstion { get; set; }

        [StringLength(50)]
        public string Images { get; set; }

        [StringLength(10)]
        public string ProductTypeID { get; set; }

        public decimal? Price { get; set; }

        [StringLength(10)]
        public string BrandsID { get; set; }

        [StringLength(50)]
        public string Sex { get; set; }

        [StringLength(10)]
        public string ProviderID { get; set; }

        public bool? Hot { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        public int? Quantity { get; set; }

        public virtual BRAND BRAND { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMPORT_COUPONDETAILS> IMPORT_COUPONDETAILS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVOICEDETAIL> INVOICEDETAILS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_details> Product_details { get; set; }

        public virtual PRODUCTSTYPE PRODUCTSTYPE { get; set; }
    }
}
