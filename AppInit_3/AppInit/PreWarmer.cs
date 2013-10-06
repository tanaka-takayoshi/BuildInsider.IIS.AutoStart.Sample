using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace AppInit
{
    public class PreWarmer : IProcessHostPreloadClient
    {

        public void Preload(string[] parameters)
        {
            HttpRuntime.Cache["IsPreWarmed"] = "Pre-Warmed";
        }
    }
}