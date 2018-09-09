using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace seagulllmarine.App_Code
{
    public class Application : System.Web.HttpApplication
    {
        protected void Application_Start()
        {         
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}