namespace ShopBridgeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class shipment_status
    {
        [Key]
        [Column(Order = 0)]
        public int shipmentstatusid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shipmentid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lineitemid { get; set; }

        public int orderstatusid { get; set; }

        public DateTime createtimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string lastupdateui { get; set; }

        public virtual order_status order_status { get; set; }

        public virtual shipment shipment { get; set; }
    }
}
