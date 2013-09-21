
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Domain.Interfaces;
using Infrastructure.Data;
using Services;
using Services.Interfaces;

namespace OnionArchitecture.Sample.Installers
{
    public class AppInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<IUserService>().ImplementedBy<UserService>().LifestyleTransient());
            container.Register(Component.For<IUserRepository>().ImplementedBy<UserRepository>().LifestyleTransient());

        }
    }
}