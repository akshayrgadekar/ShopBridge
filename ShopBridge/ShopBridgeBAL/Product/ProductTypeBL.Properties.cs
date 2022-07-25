using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridgeBAL
{
   public partial class ProductTypeBL
    {
        public ProductTypeBL()
        {
            products = new HashSet<ProductBL>();
        }
        public int producttypeid { get; set; }
        public string producttypename { get; set; }
        public string producttypedescription { get; set; }
        public DateTime createtimestamp { get; set; }
        public string createui { get; set; }
        public DateTime lastupdatetimestamp { get; set; }
        public string lastupdateui { get; set; }
       public virtual ICollection<ProductBL> products { get; set; }
    }
}
