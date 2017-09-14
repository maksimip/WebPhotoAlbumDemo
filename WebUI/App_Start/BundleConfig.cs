using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css",
                                                                  "~/Content/font-awesome.css",
                                                                  "~/Content/album.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-3.1.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include("~/Scripts/umd/popper.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/holder").Include("~/Scripts/holder.js"));


            BundleTable.EnableOptimizations = true;
        }
    }
}