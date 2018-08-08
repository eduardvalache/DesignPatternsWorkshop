using Autofac;

namespace MarvelApp.Ex2.DomainServices.Autofac
{
    public class DomainServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FightDomainService>().As<IFightDomainService>();
        }
    }
}