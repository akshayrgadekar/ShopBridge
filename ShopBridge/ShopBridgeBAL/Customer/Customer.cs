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
    /// Business class of Customer
    /// </summary>
    public partial class Customer : ICustomer
    {
       

        #region Override methods

        /// <summary>
        /// This method return the all customer
        /// </summary>
        /// <returns>Customer List</returns>
        public List<ICustomer> GetCustomers()
        {
            List<ICustomer> customers = new List<ICustomer>();
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                shopBridgeContext.customers.ToList().ForEach(cust =>
                {
                    customers.Add(ClassyMap.New().Map<Customer>(cust));
                });
            }
            return customers;
        }

        /// <summary>
        /// This method return the all customer
        /// </summary>
        /// <returns>Customer List</returns>
        public ICustomer GetCustomers(int id)
        {
            List<ICustomer> customers = new List<ICustomer>();
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                shopBridgeContext.customers.Where(cust => cust.custid == id).ToList().ForEach(cust =>
                {
                    customers.Add(ClassyMap.New().Map<Customer>(cust));
                });
            }
            return customers.FirstOrDefault();
        }
        /// <summary>
        /// Saves the customer
        /// </summary>
        /// <param name="_customer">Customer to save in database</param>
        public void SaveCustomer(ICustomer _customer)
        {
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                shopBridgeContext.customers.Add(ClassyMap.New().Map<customer>(_customer));
                shopBridgeContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update the given customer
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="customer">Customer Object</param>
        public void UpdateCustomer(int id, ICustomer customer)
        {
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                if (!shopBridgeContext.customers.Any(cust => cust.custid == id))
                {
                    throw new Exception("Customer not present in system");
                }
                else
                {
                    customer customerdata = shopBridgeContext.customers.FirstOrDefault(cust => cust.custid == id);
                    var cutomerInputs = (Customer)customer;

                    customerdata.custfname = cutomerInputs.custfname;
                    customerdata.custlname = cutomerInputs.custlname;
                    customerdata.custdob = cutomerInputs.custdob;
                    customerdata.customeremail = cutomerInputs.customeremail;
                    customerdata.customerphonenumber = cutomerInputs.customerphonenumber;
                    customerdata.lastupdatetimestamp = DateTime.Now;
                    customerdata.custaddress = cutomerInputs.custaddress;
                    customerdata.custcity = cutomerInputs.custcity;
                    customerdata.custstate = cutomerInputs.custstate;
                    customerdata.custcountry = cutomerInputs.custcountry;
                    customerdata.custzipcode = cutomerInputs.custzipcode;

                    shopBridgeContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Delete the customer
        /// </summary>
        /// <param name="id">Id to delete customer</param>
        public void DeleteCustomer(int id)
        {
            using (ShopBridgeContext shopBridgeContext = new ShopBridgeContext())
            {
                if (!shopBridgeContext.customers.Any(cust => cust.custid == id))
                {
                    throw new Exception("Customer not present in system");
                }
                else
                {
                    shopBridgeContext.customers.Remove(shopBridgeContext.customers.FirstOrDefault(cust => cust.custid == id));
                    shopBridgeContext.SaveChanges();
                }
            }
        }


        #endregion Override methods
    }
}
