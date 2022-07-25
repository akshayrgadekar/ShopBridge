using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridgeBAL
{
    /// <summary>
    /// Interface Product
    /// </summary>
    public interface IProductBL
    {
        /// <summary>
        /// Get Product
        /// </summary>
        /// <returns>List of product</returns>
        List<IProductBL> GetProduct();
        /// <summary>
        /// Get the product of given id
        /// </summary>
        /// <param name="id">Id to retrive the product</param>
        /// <returns>Prodcut</returns>
        IProductBL GetProduct(int id);
        /// <summary>
        /// Save the product
        /// </summary>
        /// <param name="product">Product</param>
        void SaveProduct(IProductBL product);
        /// <summary>
        /// Update the product
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="product">Product</param>
        void UpdateProduct(int id, IProductBL product);
        /// <summary>
        /// Delete the product
        /// </summary>
        /// <param name="id">Product id to delete the product</param>
        void DeleteProduct(int id);
    }
}
