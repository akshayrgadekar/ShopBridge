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
    /// Business class of product type 
    /// </summary>
    public partial class ProductTypeBL : IProductTypeBL
    {
        
        /// <summary>
        /// Get product type of given id
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>Product</returns>
        public IProductTypeBL GetProductType(int id)
        {
            List<IProductTypeBL> productTypes = new List<IProductTypeBL>();
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                shopBridgeContext.product_type.Where(PType=> PType.producttypeid== id).ToList().ForEach(ProdType =>
                {
                    productTypes.Add(ClassyMap.New().Map<ProductTypeBL>(ProdType));
                });
            }
            return productTypes.FirstOrDefault();
        }

        /// <summary>
        /// Get all product types
        /// </summary>
        /// <returns>List of product types</returns>
        public List<IProductTypeBL> GetProductTypes()
        {
            List<IProductTypeBL> productTypes = new List<IProductTypeBL>();
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                shopBridgeContext.product_type.ToList().ForEach(ProdType =>
                {
                    productTypes.Add(ClassyMap.New().Map<ProductTypeBL>(ProdType));
                });
            }
            return productTypes;
        }

        /// <summary>
        /// Save the product type
        /// </summary>
        /// <param name="productType">Product type</param>
        public void SaveProductType(IProductTypeBL productType)
        {
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                shopBridgeContext.product_type.Add(ClassyMap.New().Map<product_type>(productType));
                shopBridgeContext.SaveChanges();
            }
        }
        /// <summary>
        /// Update the product type
        /// </summary>
        /// <param name="id">Product type id</param>
        /// <param name="prodType">Product type to update</param>
        public void UpdateProductType(int id, IProductTypeBL prodType)
        {
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                if (!shopBridgeContext.product_type.Any(pType => pType.producttypeid == id))
                {
                    throw new Exception("Product Type not present in system");
                }
                else
                {
                    product_type ProductTypedata = shopBridgeContext.product_type.FirstOrDefault(pType => pType.producttypeid == id);
                    var ProductTypeInputs = (ProductTypeBL)prodType;

                    ProductTypedata.producttypename = ProductTypeInputs.producttypename;
                    ProductTypedata.producttypedescription = ProductTypeInputs.producttypedescription;
                    ProductTypedata.lastupdatetimestamp = DateTime.Now;

                    shopBridgeContext.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Delete the product type
        /// </summary>
        /// <param name="id">Id to delete product type</param>
        public void DeleteProductType(int id)
        {
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                if (!shopBridgeContext.product_type.Any(pType => pType.producttypeid == id))
                {
                    throw new Exception("Product type not present in system");
                }
                else
                {
                    shopBridgeContext.product_type.Remove(shopBridgeContext.product_type.FirstOrDefault(pType => pType.producttypeid == id));
                    shopBridgeContext.SaveChanges();
                }
            }
        }
    }
}
