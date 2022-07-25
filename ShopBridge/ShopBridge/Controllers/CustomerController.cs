using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShopBridgeBAL;
using ShopBridge.Common;

namespace ShopBridge.Controllers
{

    public class CustomerController : ApiController
    {

        ICustomer _customer;

        public CustomerController(ICustomer customer)
        {
            _customer = customer;
        }

        // GET: api/Customer        
        public HttpResponseMessage Get()
        {
            var Customers = _customer.GetCustomers();
            if (Customers == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK,Customers);
        }

        // GET: api/Customer/5
        public HttpResponseMessage Get(int id)
        {
            var Customer = _customer.GetCustomers(id);
            if (Customer == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK,Customer);
        }

        // POST: api/Customer       
        public HttpResponseMessage Post([FromBody] Customer customer)
        {
            _customer.SaveCustomer(customer);
            var response = Request.CreateResponse(HttpStatusCode.Created, customer);
            return response;
        }

        // PUT: api/Customer/5       
        public HttpResponseMessage Put(int id, [FromBody] Customer customer)
        {
            _customer.UpdateCustomer(id, customer);
            var response = Request.CreateResponse(HttpStatusCode.OK, customer);
            return response;
        }

        // DELETE: api/Customer/5
        public HttpResponseMessage Delete(int id)
        {
            _customer.DeleteCustomer(id);
            var response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
    }
}
