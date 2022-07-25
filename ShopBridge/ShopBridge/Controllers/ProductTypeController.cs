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
    public class ProductTypeController : ApiController
    {
        IProductTypeBL _productTypeBL;

        public ProductTypeController(IProductTypeBL productTypeBL)
        {
            _productTypeBL = productTypeBL;
        }
        // GET: api/ProductType
        public HttpResponseMessage Get()
        {
            var ProductTypes = _productTypeBL.GetProductTypes();
            if (ProductTypes == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(ProductTypes);
        }

        // GET: api/ProductType/5
        public HttpResponseMessage Get(int id)
        {
            var ProductTypes = _productTypeBL.GetProductType(id);
            if (ProductTypes == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(ProductTypes);
        }

        // POST: api/ProductType
        public HttpResponseMessage Post([FromBody]ProductTypeBL ProductType)
        {
            _productTypeBL.SaveProductType(ProductType);
            var response = Request.CreateResponse(HttpStatusCode.Created, ProductType);
            return response;
        }

        // PUT: api/ProductType/5
        public HttpResponseMessage Put(int id, [FromBody] ProductTypeBL  ProductType)
        {
            _productTypeBL.UpdateProductType(id, ProductType);
            var response = Request.CreateResponse(HttpStatusCode.OK, ProductType);
            return response;
        }

        // DELETE: api/ProductType/5
        public HttpResponseMessage Delete(int id)
        {
            _productTypeBL.DeleteProductType(id);
            var response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
    }
}
