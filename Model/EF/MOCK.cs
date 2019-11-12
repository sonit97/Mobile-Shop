namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MOCK : DbContext
    {
        public MOCK()
            : base("name=MOCKPROJECT")
        {
        }

        public virtual DbSet<BRAND> BRANDS { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERS { get; set; }
        public virtual DbSet<CUSTOMERTYPE> CUSTOMERTYPEs { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        public virtual DbSet<IMAGEPRODUCT> IMAGEPRODUCTs { get; set; }
        public virtual DbSet<IMPORT_COUPON> IMPORT_COUPON { get; set; }
        public virtual DbSet<IMPORT_COUPONDETAILS> IMPORT_COUPONDETAILS { get; set; }
        public virtual DbSet<INVOICE> INVOICEs { get; set; }
        public virtual DbSet<INVOICEDETAIL> INVOICEDETAILS { get; set; }
        public virtual DbSet<Product_details> Product_details { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTS { get; set; }
        public virtual DbSet<PRODUCTSTYPE> PRODUCTSTYPEs { get; set; }
        public virtual DbSet<PROVIDER> PROVIDERs { get; set; }
        public virtual DbSet<SIZE> SIZEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BRAND>()
                .Property(e => e.BrandsID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CustomerTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMERTYPE>()
                .Property(e => e.CustomerTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .HasMany(e => e.IMPORT_COUPON)
                .WithOptional(e => e.EMPLOYEE)
                .HasForeignKey(e => e.EmpployeeID);

            modelBuilder.Entity<EMPLOYEE>()
                .HasMany(e => e.INVOICEs)
                .WithOptional(e => e.EMPLOYEE)
                .HasForeignKey(e => e.EmpployeeID);

            modelBuilder.Entity<IMAGEPRODUCT>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<IMAGEPRODUCT>()
                .Property(e => e.Image1)
                .IsUnicode(false);

            modelBuilder.Entity<IMAGEPRODUCT>()
                .Property(e => e.Image2)
                .IsUnicode(false);

            modelBuilder.Entity<IMAGEPRODUCT>()
                .Property(e => e.Image3)
                .IsUnicode(false);

            modelBuilder.Entity<IMPORT_COUPON>()
                .Property(e => e.Import_CouponID)
                .IsUnicode(false);

            modelBuilder.Entity<IMPORT_COUPON>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<IMPORT_COUPON>()
                .HasMany(e => e.IMPORT_COUPONDETAILS)
                .WithRequired(e => e.IMPORT_COUPON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IMPORT_COUPONDETAILS>()
                .Property(e => e.Import_CouponID)
                .IsUnicode(false);

            modelBuilder.Entity<IMPORT_COUPONDETAILS>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<IMPORT_COUPONDETAILS>()
                .Property(e => e.SizeID)
                .IsUnicode(false);

            modelBuilder.Entity<IMPORT_COUPONDETAILS>()
                .Property(e => e.PriceBuy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<INVOICE>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICE>()
                .HasMany(e => e.INVOICEDETAILS)
                .WithRequired(e => e.INVOICE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INVOICEDETAIL>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEDETAIL>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEDETAIL>()
                .Property(e => e.SizeID)
                .IsUnicode(false);

            modelBuilder.Entity<INVOICEDETAIL>()
                .Property(e => e.PriceSale)
                .HasPrecision(18, 0);

            modelBuilder.Entity<INVOICEDETAIL>()
                .Property(e => e.PriceSell)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product_details>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<Product_details>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product_details>()
                .Property(e => e.SizeID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.ProductTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.BrandsID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .HasMany(e => e.IMPORT_COUPONDETAILS)
                .WithRequired(e => e.PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCT>()
                .HasMany(e => e.INVOICEDETAILS)
                .WithRequired(e => e.PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCT>()
                .HasMany(e => e.Product_details)
                .WithRequired(e => e.PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTSTYPE>()
                .Property(e => e.ProductTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<PROVIDER>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<PROVIDER>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<PROVIDER>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SIZE>()
                .Property(e => e.SizeID)
                .IsUnicode(false);
        }
    }
}
