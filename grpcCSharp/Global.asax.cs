namespace KNet
{
    using System.Web;

    public class WebApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GrpcInitializer.EnsureGrpcCSharpExtNativeDll();
        }
    }
}