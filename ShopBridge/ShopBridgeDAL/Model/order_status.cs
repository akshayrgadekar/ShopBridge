namespace ShopBridgeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order_status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order_status()
        {
            shipment_status = new HashSet<shipment_status>();
        }

        [Key]
        public int orderstatusid { get; set; }

        [Required]
        [StringLength(50)]
        public string orderstatusname { get; set; }

        public DateTime createtimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string lastupdateui { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shipment_status> shipment_status { get; set; }
    }
}
