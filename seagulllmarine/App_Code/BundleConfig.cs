using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace seagulllmarine
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/js/bootstrap.min.js",
                      "~/js/jquery-2.2.4.min.js",
                      "~/js/jquery-ui.min.js",
                      "~/js/jquery-plugin-collection.js",
                      "~/js/revolution-slider/js/jquery.themepunch.tools.min.js",
                      "~/js/revolution-slider/js/jquery.themepunch.revolution.min.js",
                       "~/js/custom.js",
                       "~/js/revolution-slider/js/extensions/revolution.extension.actions.min.js",
                       "~/js/revolution-slider/js/extensions/revolution.extension.carousel.min.js",
                       "~/js/revolution-slider/js/extensions/revolution.extension.kenburn.min.js",
                       "~/js/revolution-slider/js/extensions/revolution.extension.layeranimation.min.js",
                       "~/js/revolution-slider/js/extensions/revolution.extension.migration.min.js",
                       "~/js/revolution-slider/js/extensions/revolution.extension.navigation.min.js",
                       "~/js/revolution-slider/js/extensions/revolution.extension.slideanims.min.js",
                       "~/js/revolution-slider/js/extensions/revolution.extension.video.min.js"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                   "~/css/bootstrap.min.css",
                   "~/css/jquery-ui.min.css",
                   "~/css/animate.css",
                   "~/css/css-plugin-collections.css",
                   "~/css/menuzord-skins/menuzord-rounded-boxed.css",
                   "~/css/style-main.css",
                   "~/css/preloader.css",
                   "~/css/custom-bootstrap-margin-padding.css",
                   "~/css/responsive.css",
                   "~/js/revolution-slider/css/settings.css",
                   "~/js/revolution-slider/css/layers.css",
                   "~/js/revolution-slider/css/navigation.css",
                   "~/css/colors/theme-skin-color-set-1.css"));
        }
    }
}