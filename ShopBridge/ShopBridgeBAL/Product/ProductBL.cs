using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBridgeDAL;
using ClassyMapper;
using System.Reflection;

namespace ShopBridgeBAL
{
    /// <summary>
    /// Product Class
    /// </summary>
    public partial class ProductBL : IProductBL
    {
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>List of products</returns>
        public List<IProductBL> GetProduct()
        {
            List<IProductBL> products = new List<IProductBL>();
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                shopBridgeContext.products.ToList().ForEach(Prod =>
                {
                    products.Add(ClassyMap.New().Map<ProductBL>(Prod));
                });
            }
            return products;
        }
        /// <summary>
        /// Get product for given id
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Product</returns>
        public IProductBL GetProduct(int id)
        {
            List<IProductBL> products = new List<IProductBL>();
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                shopBridgeContext.products.Where(p => p.productid == id).ToList().ForEach(Prod =>
                  {
                      products.Add(ClassyMap.New().Map<ProductBL>(Prod));
                  });
            }
            return products.FirstOrDefault();
        }
        /// <summary>
        /// Save the prodcut
        /// </summary>
        /// <param name="Product">Product Object</param>
        public void SaveProduct(IProductBL Product)
        {
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                shopBridgeContext.products.Add(ClassyMap.New().Map<product>(Product));
                shopBridgeContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update the product of given id
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <param name="Product">Product</param>
        public void UpdateProduct(int id, IProductBL Product)
        {
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                if (!shopBridgeContext.products.Any(prod => prod.productid == id))
                {
                    throw new Exception("Product not present in system");
                }
                else
                {
                    product Productdata = shopBridgeContext.products.FirstOrDefault(prod => prod.productid == id);
                    var ProductInputs = (ProductBL)Product;

                    Productdata.producttypeid = ProductInputs.producttypeid;
                    Productdata.productname = ProductInputs.productname;
                    Productdata.productdescription = ProductInputs.productdescription;
                    Productdata.price = ProductInputs.price;
                    Productdata.lastupdatetimestamp = DateTime.Now;                  

                    shopBridgeContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Delete the product of given id
        /// </summary>
        /// <param name="id">Product id</param>
        public void DeleteProduct(int id)
        {
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                if (!shopBridgeContext.customers.Any(cust => cust.custid == id))
                {
                    throw new Exception("Product not present in system");
                }
                else
                {
                    shopBridgeContext.products.Remove(shopBridgeContext.products.FirstOrDefault(prod => prod.productid == id));
                    shopBridgeContext.SaveChanges();
                }
            }
        }
    }
}
