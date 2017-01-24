using System.Web;
using System.Web.Optimization;

namespace ContactWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Lib/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/Lib/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                      "~/Scripts/Lib/jquery.dataTables.min.js",
                      "~/Scripts/Lib/dataTables.bootstrap.min.js",
                      "~/Scripts/Lib/dataTables.colReorder.min.js"));

            

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/jquery.dataTables.min.css",
                      "~/Content/jquery.dataTables_themeroller.css",
                      "~/Content/dataTables.bootstrap.min.css",
                      "~/Content/colReorder.bootstrap.min.css",
                      "~/Content/site.css"));
        }
    }
}
