using System.Web;
using System.Web.Optimization;

namespace BeerBoutique
{
    public class BundleConfig
    {
        public static string SCRIPT_JQUERY = "~/bundles/jquery";
        public static string SCRIPT_JQUERYUI = "~/bundles/jqueryui";
        public static string SCRIPT_JQUERYVAL = "~/bundles/jqueryval";
        public static string SCRIPT_MODERNIZR = "~/bundles/modernizr";
        public static string SCRIPT_BOOTSTRAP = "~/bundles/bootstrap";
        public static string SCRIPT_DATATABLE = "~/bundles/datatable";
        public static string SCRIPT_KNOCKOUTJS = "~/bundles/knockoutjs";
        public static string SCRIPT_YEAST = "~/styles/yeast";
        public static string STYLE_JQUERY = "~/Content/themes/base";
        public static string STYLE_BOOTSTRAP = "~/Content/bootstrap";

        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(SCRIPT_YEAST).Include("~/Scripts/Script.js"));

            bundles.Add(new ScriptBundle(SCRIPT_JQUERY).Include("~/Scripts/jquery-{version}.js", "~/Scripts/jquery.rateit.js"));

            bundles.Add(new ScriptBundle(SCRIPT_JQUERYUI).Include("~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle(SCRIPT_JQUERYVAL).Include("~/Scripts/jquery.validate*", "~/Scripts/jquery.unobtrusive*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle(SCRIPT_MODERNIZR).Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle(SCRIPT_BOOTSTRAP).Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle(SCRIPT_DATATABLE).Include("~/Scripts/jquery.dataTables.js"));

            bundles.Add(new ScriptBundle(SCRIPT_KNOCKOUTJS).Include("~/Scripts/knockout-{version}.js", "~/Scripts/knockout.mapping-latest.js"));

            bundles.Add(new StyleBundle(STYLE_JQUERY).Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle(STYLE_BOOTSTRAP).Include("~/Content/bootstrap.css", "~/Content/bootstrap-responsive.css", "~/Content/Site.css", "~/Content/rateit.css"));
        }
    }
}