using System.Web.Mvc;
using Infrastructure.DependencyResolution;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(ControllerFactoryWireup), "PostStartup")]
namespace Infrastructure.DependencyResolution
{
    public static class ControllerFactoryWireup
    {
        public static void PostStartup()
        {
#pragma warning disable 618
            var factory = IoC.Container.Resolve<IControllerFactory>();
#pragma warning restore 618
            ControllerBuilder.Current.SetControllerFactory(factory);
        }
    }
}
