using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;
namespace ShopBridge.Common
{
    public class TrackExceptionAttribute : ExceptionFilterAttribute
    {

        private ILog _ilog;
        public TrackExceptionAttribute()
        {
            _ilog = Log.GetInstance;
        }

        public override void OnException(HttpActionExecutedContext context)
        {
            _ilog.LogException(context.Exception.ToString());

            context.Response= new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new StringContent(context.Exception.Message),
                ReasonPhrase = "Exception Handler"
            };
        }
    }
}