using System.Web;
using System.Web.Optimization;

namespace SMS
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // jQuery Bundle
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // jQuery Validation Bundle
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Modernizr Bundle
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // Bootstrap JavaScript Bundle
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // Bootstrap CSS Bundle
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
