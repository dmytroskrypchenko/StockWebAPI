namespace Stock.Services.ConnectionType
{
    using Autofac;

    public class Bootstrapper : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConnectionTypeService>();
            builder.RegisterType<BL.Services.Concrete.ConnectionTypeService>().As<BL.Services.Abstract.IConnectionTypeService>();
        }
    }
}