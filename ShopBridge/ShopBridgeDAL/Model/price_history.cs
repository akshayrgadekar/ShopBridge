namespace ShopBridgeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class price_history
    {
        [Key]
        public int pricehistoryid { get; set; }

        public int productid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal price { get; set; }

        public DateTime pricingtimestamp { get; set; }

        public DateTime createtimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string lastupdateui { get; set; }

        public virtual product product { get; set; }
    }
}
