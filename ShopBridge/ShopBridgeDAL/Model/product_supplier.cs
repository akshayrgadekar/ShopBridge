namespace ShopBridgeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product_supplier
    {
        [Key]
        public int productsupplierid { get; set; }

        public int productid { get; set; }

        public int supplierid { get; set; }

        public int productquantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? orderplaceddate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? orderdelivereddate { get; set; }

        public DateTime createtimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string lastupdateui { get; set; }

        public virtual product product { get; set; }

        public virtual supplier supplier { get; set; }
    }
}
