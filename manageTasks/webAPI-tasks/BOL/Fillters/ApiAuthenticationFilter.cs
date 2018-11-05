using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;


namespace BOL.Fillters
{
    class ApiAuthenticationFilter
    {
        //protected override bool OnAuthorizeUser(string username, string password, HttpActionContext actionContext)
        //{
        //    var provider = actionContext.ControllerContext.Configuration
        //                       .DependencyResolver.GetService(typeof(IUserServices)) as IUserServices;
        //    if (provider != null)
        //    {
        //        var userId = provider.Authenticate(username, password);
        //        if (userId > 0)
        //        {
        //            var basicAuthenticationIdentity = Thread.CurrentPrincipal.Identity as BasicAuthenticationIdentity;
        //            if (basicAuthenticationIdentity != null)
        //                basicAuthenticationIdentity.UserId = userId;
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
