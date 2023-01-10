using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApplication3.Filter
{
    public class AthorizationFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.FirstOrDefault(x => x.Key == "Token").Value;
            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
            }
            if (token.FirstOrDefault() != "23212")
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            base.OnAuthorization(actionContext);
        }
    }
}