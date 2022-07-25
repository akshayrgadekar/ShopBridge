using System.Web.Mvc;
using Unity;
using ShopBridgeBAL;
using System.Web.Http;
using Unity.WebApi;

namespace ShopBridge
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<ICustomer, ShopBridgeBAL.Customer>();
            container.RegisterType < IProductTypeBL, ShopBridgeBAL.ProductTypeBL> ();
            container.RegisterType<IProductBL, ShopBridgeBAL.ProductBL>();          
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}