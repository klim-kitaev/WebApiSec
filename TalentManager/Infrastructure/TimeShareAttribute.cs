using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace TalentManager.Infrastructure
{
    public class TimeShareAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            IPrincipal principal = Thread.CurrentPrincipal;
            // If principal.IsInRole("TimeSharer")
            // Check if current time is between allocated slot start and end times
            // If not, return false
            return true;
        }

    }
}