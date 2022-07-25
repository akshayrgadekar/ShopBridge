using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridgeBAL
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProductTypeBL
    {
        /// <summary>
        /// Get Product type list
        /// </summary>
        /// <returns>List of product type</returns>
        List<IProductTypeBL> GetProductTypes();
        /// <summary>
        /// Get Product type
        /// </summary>
        /// <param name="id">Product type id</param>
        /// <returns>Product type</returns>
        IProductTypeBL GetProductType(int id);
        /// <summary>
        /// Save the product type
        /// </summary>
        /// <param name="productType">Product type to save</param>
        void SaveProductType(IProductTypeBL productType);
        /// <summary>
        /// Update the product type
        /// </summary>
        /// <param name="id">Id to update the product type</param>
        /// <param name="productType">Product type</param>
        void UpdateProductType(int id, IProductTypeBL productType);
        /// <summary>
        /// Delete the product type
        /// </summary>
        /// <param name="id">Product type id</param>
        void DeleteProductType(int id);
    }
}
