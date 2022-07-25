namespace ShopBridgeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("supplier")]
    public partial class supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supplier()
        {
            product_supplier = new HashSet<product_supplier>();
        }

        public int supplierid { get; set; }

        [Required]
        [StringLength(75)]
        public string suppliername { get; set; }

        [Column(TypeName = "date")]
        public DateTime onboardingdate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? supplierestablishmentdate { get; set; }

        [Required]
        [StringLength(20)]
        public string supplierprimarycontact { get; set; }

        [StringLength(20)]
        public string suppliersecondarycontact { get; set; }

        [StringLength(50)]
        public string supplieremail { get; set; }

        [Required]
        [StringLength(500)]
        public string supplieraddress { get; set; }

        [Required]
        [StringLength(75)]
        public string suppliercity { get; set; }

        [Required]
        [StringLength(75)]
        public string supplierstate { get; set; }

        [Required]
        [StringLength(75)]
        public string suppliercountry { get; set; }

        [Required]
        [StringLength(75)]
        public string supplierzipcode { get; set; }

        public DateTime createtimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string lastupdateui { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product_supplier> product_supplier { get; set; }
    }
}
