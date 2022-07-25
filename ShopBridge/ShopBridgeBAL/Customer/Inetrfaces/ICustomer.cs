using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridgeBAL
{
    /// <summary>
    /// Customer Interface
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// Get Customer List
        /// </summary>
        /// <returns>List of customer</returns>
        List<ICustomer> GetCustomers();
        /// <summary>
        /// GetCustomer
        /// </summary>
        /// <param name="id">Id to retrive customer</param>
        /// <returns>Customer</returns>
        ICustomer GetCustomers(int id);
        /// <summary>
        /// Save the customer
        /// </summary>
        /// <param name="customer"></param>
        void SaveCustomer(ICustomer customer);
        /// <summary>
        /// Update the Customer
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="customer">Customer</param>
        void UpdateCustomer(int id, ICustomer customer);
        /// <summary>
        /// Delete the customer
        /// </summary>
        /// <param name="id">Id to delete customer</param>
        void DeleteCustomer(int id);
    }
}
