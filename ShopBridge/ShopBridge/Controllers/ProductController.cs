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
    public class ProductController : ApiController
    {
        IProductBL _productBL;
        public ProductController(IProductBL productBL)
        {
            _productBL = productBL;
        }
        // GET: api/Product
        public HttpResponseMessage Get()
        {
            var Products =_productBL.GetProduct();
            if (Products == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(Products);
        }

        // GET: api/Product/5
        public HttpResponseMessage  Get(int id)
        {
            var Products = _productBL.GetProduct(id);
            if (Products == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(Products);
        }

        // POST: api/Product
        public HttpResponseMessage Post([FromBody]ProductBL product)
        {
            _productBL.SaveProduct(product);
            var response = Request.CreateResponse(HttpStatusCode.Created, product);
            return response;
        }

        // PUT: api/Product/5
        public HttpResponseMessage Put(int id, [FromBody] ProductBL product)
        {
            _productBL.UpdateProduct(id, product);
            var response = Request.CreateResponse(HttpStatusCode.OK, product);
            return response;
        }

        // DELETE: api/Product/5
        public HttpResponseMessage Delete(int id)
        {
            _productBL.DeleteProduct(id);
            var response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
    }
}
