namespace Stock.Services.Manufacturer
{
    using Autofac;

    public class Bootstrapper : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ManufacturerService>();
            builder.RegisterType<BL.Services.Concrete.ManufacturerService>().As<BL.Services.Abstract.IManufacturerService>();
        }
    }
}