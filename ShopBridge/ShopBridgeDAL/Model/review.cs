namespace ShopBridgeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class review
    {
        public int reviewid { get; set; }

        public int custid { get; set; }

        public int lineitemid { get; set; }

        public int ratingid { get; set; }

        [Required]
        [StringLength(500)]
        public string reviewtext { get; set; }

        public DateTime createtimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string lastupdateui { get; set; }

        public virtual customer customer { get; set; }

        public virtual lineitem lineitem { get; set; }

        public virtual rating rating { get; set; }
    }
}
