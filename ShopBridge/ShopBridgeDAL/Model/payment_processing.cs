namespace ShopBridgeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class payment_processing
    {
        [Key]
        public int paymentprocessingid { get; set; }

        public int paymentid { get; set; }

        public int paymentstatusid { get; set; }

        [Required]
        [StringLength(50)]
        public string iscurrentstate { get; set; }

        public DateTime createtimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string lastupdateui { get; set; }

        public virtual payment payment { get; set; }

        public virtual payment_status payment_status { get; set; }
    }
}
