using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridgeBAL
{
    public partial class Customer
    {

        #region Properties

        public int custid { get; set; }
        public string custfname { get; set; }
        public string custlname { get; set; }
        public DateTime custdob { get; set; }
        public string customeremail { get; set; }
        public string customerphonenumber { get; set; }
        public DateTime createtimestamp { get; set; }
        public string createui { get; set; }
        public DateTime lastupdatetimestamp { get; set; }
        public string lastupdateui { get; set; }
        public string custaddress { get; set; }
        public string custcity { get; set; }
        public string custstate { get; set; }
        public string custcountry { get; set; }
        public string custzipcode { get; set; }

        #endregion Properties

    }
}
