﻿using System.Web.Optimization;

namespace jQuery.Validation.Unobtrusive.Native.Demos.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-validation").Include("~/Scripts/jquery.validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include("~/Scripts/knockout.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/site.css"));
        }
    }
}