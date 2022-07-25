namespace ShopBridgeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class delivery_partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public delivery_partner()
        {
            shipments = new HashSet<shipment>();
        }

        [Key]
        public int deliverypartnerid { get; set; }

        [Required]
        [StringLength(75)]
        public string deliverypartnername { get; set; }

        [Column(TypeName = "date")]
        public DateTime deliverypartneronboardingdate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? deliverypartnerestdate { get; set; }

        [Required]
        [StringLength(20)]
        public string deliverypartnerprimarycontact { get; set; }

        [StringLength(20)]
        public string deliverypartnersecondarycontact { get; set; }

        [Required]
        [StringLength(50)]
        public string deliverypartneremail { get; set; }

        [Required]
        [StringLength(500)]
        public string deliverypartneraddress { get; set; }

        [Required]
        [StringLength(75)]
        public string deliverypartnercity { get; set; }

        [Required]
        [StringLength(75)]
        public string deliverypartnerstate { get; set; }

        [Required]
        [StringLength(75)]
        public string deliverypartnercountry { get; set; }

        [Required]
        [StringLength(75)]
        public string deliverypartnerzipcode { get; set; }

        public DateTime createtimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string lastupdateui { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shipment> shipments { get; set; }
    }
}
