namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMERS")]
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            INVOICEs = new HashSet<INVOICE>();
        }

        public int CustomerID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên khách hàng*:")]
        [Required(ErrorMessage = "Mời nhập tên!!")]
        public string CustomerName { get; set; }

        [StringLength(50)]
        [Display(Name = "Số điện thoại*:")]
        [Required(ErrorMessage = "Mời nhập SĐT!!")]
        public string Phone { get; set; }
        [Display(Name = "Ngày sinh*:")]
        [Required(ErrorMessage = "Mời nhập ngày sinh!!")]
        public DateTime? BirthDay { get; set; }

        [StringLength(50)]
        [Display(Name = "Giới tính*:")]
        [Required(ErrorMessage = "Mời nhập giới tính!!")]
        public string Sex { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ*:")]
        [Required(ErrorMessage = "Mời nhập địa chỉ!!")]
        public string Address { get; set; }

        [StringLength(50)]
        [Display(Name = "Email*:")]
        [Required(ErrorMessage = "Mời nhập Email!!")]
        public string Email { get; set; }

        [StringLength(10)]
        public string CustomerTypeID { get; set; }

        [StringLength(50)]
        [Display(Name = "Password*:")]
        public string Password { get; set; }

        public int? Point { get; set; }

        public virtual CUSTOMERTYPE CUSTOMERTYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVOICE> INVOICEs { get; set; }
    }
}
