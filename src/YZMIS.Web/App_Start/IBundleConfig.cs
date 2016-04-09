using System.Web.Optimization;

namespace YZMIS.Web
{
    public interface IBundleConfig
    {
        void RegisterBundles(BundleCollection bundles);
    }
}
