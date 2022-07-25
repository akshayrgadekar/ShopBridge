using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridgeBAL
{
    public partial class ProductBL
    {

        public int productid { get; set; }

        public int producttypeid { get; set; }

        public string productname { get; set; }

        public string productdescription { get; set; }

        public decimal price { get; set; }

        public DateTime createtimestamp { get; set; }

        public string createui { get; set; }

        public DateTime lastupdatetimestamp { get; set; }

        public string lastupdateui { get; set; }
    }
}
