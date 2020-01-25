using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace NoavaranJahan
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/App_theme/Noavaran/js/jquery-{version}.js",
                        "~/App_theme/Noavaran/js/bootstrap.min.js",
                        "~/App_theme/Noavaran/js/navbar.js",
                        "~/App_theme/Noavaran/js/owl.carousel.min.js",
                        "~/App_theme/Noavaran/js/all.min.js",
                        "~/App_theme/Noavaran/js/jquery.fancybox.min.js"));

          
            //style
            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                      "~/App_theme/Noavaran/fonts/DroidArabic/style.css",
                      "~/App_theme/Noavaran/css/bootstrap.min.css",
                      "~/App_theme/Noavaran/css/navbar.css",
                      "~/App_theme/Noavaran/css/owl.theme.default.min.css",
                      "~/App_theme/Noavaran/css/owl.carousel.min.css",
                      "~/App_theme/Noavaran/css/r-slider.css",
                      "~/App_theme/Noavaran/css/all.min.css",
                      "~/App_theme/Noavaran/css/jquery.fancybox.min.css",
                      "~/App_theme/Noavaran/css/Style.css"));

       

        }
    }
}