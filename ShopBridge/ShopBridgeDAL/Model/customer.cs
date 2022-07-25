namespace ShopBridgeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            reviews = new HashSet<review>();
            tblorders = new HashSet<tblorder>();
        }

        [Key]
        public int custid { get; set; }

        [Required]
        [StringLength(75)]
        public string custfname { get; set; }

        [Required]
        [StringLength(75)]
        public string custlname { get; set; }

        [Column(TypeName = "date")]
        public DateTime custdob { get; set; }

        [Required]
        [StringLength(75)]
        public string customeremail { get; set; }

        [Required]
        [StringLength(20)]
        public string customerphonenumber { get; set; }

        public DateTime createtimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string lastupdateui { get; set; }

        [Required]
        [StringLength(500)]
        public string custaddress { get; set; }

        [Required]
        [StringLength(75)]
        public string custcity { get; set; }

        [Required]
        [StringLength(75)]
        public string custstate { get; set; }

        [Required]
        [StringLength(75)]
        public string custcountry { get; set; }

        [Required]
        [StringLength(75)]
        public string custzipcode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<review> reviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblorder> tblorders { get; set; }
    }
}
