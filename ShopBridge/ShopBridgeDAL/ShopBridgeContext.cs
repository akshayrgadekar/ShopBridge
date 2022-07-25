using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridgeDAL
{
    public class ShopBridgeContext : DbContext
    {
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<delivery_partner> delivery_partner { get; set; }
        public virtual DbSet<lineitem> lineitems { get; set; }
        public virtual DbSet<order_status> order_status { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<payment_processing> payment_processing { get; set; }
        public virtual DbSet<payment_status> payment_status { get; set; }
        public virtual DbSet<payment_type> payment_type { get; set; }
        public virtual DbSet<price_history> price_history { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<product_supplier> product_supplier { get; set; }
        public virtual DbSet<product_type> product_type { get; set; }
        public virtual DbSet<rating> ratings { get; set; }
        public virtual DbSet<review> reviews { get; set; }
        public virtual DbSet<shipment> shipments { get; set; }
        public virtual DbSet<shipment_status> shipment_status { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<tblorder> tblorders { get; set; }
    }
}
